using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Repositories
{
    public interface IEmpleadoRepository
    {
        IEnumerable<Empleado> ObtenerTodos();
        Empleado ObtenerPorId(int id);
        void Agregar(Empleado empleado);
        void Actualizar(Empleado empleado);
        void Eliminar(int id);
    }

    public class EmpleadoRepository : IEmpleadoRepository
    {
        private readonly List<Empleado> _empleados;

        public EmpleadoRepository()
        {
            _empleados = new List<Empleado>();
            // Aquí podrías inicializar la lista con algunos datos simulados si lo deseas
        }

        public IEnumerable<Empleado> ObtenerTodos()
        {
            return _empleados;
        }

        public Empleado ObtenerPorId(int id)
        {
            return _empleados.FirstOrDefault(e => e.Id == id);
        }

        public void Agregar(Empleado empleado)
        {
            empleado.Id = _empleados.Count + 1; // Generar un nuevo ID
            _empleados.Add(empleado);
        }

        public void Actualizar(Empleado empleado)
        {
            var empleadoExistente = _empleados.FirstOrDefault(e => e.Id == empleado.Id);
            if (empleadoExistente != null)
            {
                // Actualizar las propiedades del empleado existente
                empleadoExistente.Fotografia = empleado.Fotografia;
                empleadoExistente.Nombre = empleado.Nombre;
                empleadoExistente.Apellido = empleado.Apellido;
                empleadoExistente.PuestoId = empleado.PuestoId;
                empleadoExistente.FechaNacimiento = empleado.FechaNacimiento;
                empleadoExistente.FechaContratacion = empleado.FechaContratacion;
                empleadoExistente.Direccion = empleado.Direccion;
                empleadoExistente.Telefono = empleado.Telefono;
                empleadoExistente.CorreoElectronico = empleado.CorreoElectronico;
                empleadoExistente.EstadoId = empleado.EstadoId;
            }
        }

        public void Eliminar(int id)
        {
            var empleadoAEliminar = _empleados.FirstOrDefault(e => e.Id == id);
            if (empleadoAEliminar != null)
            {
                _empleados.Remove(empleadoAEliminar);
            }
        }
    }
}
