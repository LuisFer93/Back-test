using Microsoft.AspNetCore.Mvc;
using Repositories;
using System.Collections.Generic;
using Models;

namespace Test_datos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpleadosController : ControllerBase
    {
        private readonly IEmpleadoRepository _empleadoRepository;
        private readonly EmpleadoSimulado _empleadoSimulado;


        public EmpleadosController(IEmpleadoRepository empleadoRepository, EmpleadoSimulado empleadoSimulado)
        {
            _empleadoRepository = empleadoRepository;
            _empleadoSimulado = empleadoSimulado;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Empleado>> ObtenerTodos()
        {
            var empleados = _empleadoSimulado.ObtenerDatosSimulados();
            return Ok(empleados);
        }

        [HttpGet("{id}")]
        public ActionResult<Empleado> ObtenerPorId(int id)
        {
            var empleado = _empleadoRepository.ObtenerPorId(id);
            if (empleado == null)
            {
                return NotFound();
            }
            return Ok(empleado);
        }

        [HttpPost]
        public ActionResult<Empleado> Agregar(Empleado empleado)
        {
            _empleadoRepository.Agregar(empleado);
            return CreatedAtAction(nameof(ObtenerPorId), new { id = empleado.Id }, empleado);
        }

        [HttpPut("{id}")]
        public IActionResult Actualizar(int id, Empleado empleado)
        {
            if (id != empleado.Id)
            {
                return BadRequest();
            }
            _empleadoRepository.Actualizar(empleado);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            var empleadoExistente = _empleadoRepository.ObtenerPorId(id);
            if (empleadoExistente == null)
            {
                return NotFound();
            }
            _empleadoRepository.Eliminar(id);
            return NoContent();
        }
    }
}
