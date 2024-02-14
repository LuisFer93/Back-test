using Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Models;
namespace Services
{
    public interface IEmpleadoService
    {
        IEnumerable<Empleado> ObtenerTodosEmpleados();
        Empleado ObtenerEmpleadoPorId(int id);
        void AgregarEmpleado(Empleado empleado);
        void ActualizarEmpleado(Empleado empleado);
        void EliminarEmpleado(int id);
    }

    public class EmpleadoService : IEmpleadoService
    {
        private readonly IEmpleadoRepository _empleadoRepository;

        public EmpleadoService(IEmpleadoRepository empleadoRepository)
        {
            _empleadoRepository = empleadoRepository;
        }

        public IEnumerable<Empleado> ObtenerTodosEmpleados()
        {
            return (IEnumerable<Empleado>)_empleadoRepository.ObtenerTodos();
        }

        public Empleado ObtenerEmpleadoPorId(int id)
        {
            return _empleadoRepository.ObtenerPorId(id);
        }

        public void AgregarEmpleado(Empleado empleado)
        {
            // Lógica de negocio, validación, etc.
            _empleadoRepository.Agregar(empleado);
        }

        public void ActualizarEmpleado(Empleado empleado)
        {
            // Lógica de negocio, validación, etc.
            _empleadoRepository.Actualizar(empleado);
        }

        public void EliminarEmpleado(int id)
        {
            // Lógica de negocio, validación, etc.
            _empleadoRepository.Eliminar(id);
        }
    }

}
