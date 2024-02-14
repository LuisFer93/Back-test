using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Fotografia { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int PuestoId { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaContratacion { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public int EstadoId { get; set; }
    }

    public class EmpleadoSimulado
    {
        public Empleado[] ObtenerDatosSimulados()
        {
            Empleado[] empleados = new Empleado[]
            {
                new Empleado
                {
                    Id = 1,
                    Fotografia = "foto1.jpg",
                    Nombre = "Juan",
                    Apellido = "Pérez",
                    PuestoId = 1,
                    FechaNacimiento = new DateTime(1990, 5, 15),
                    FechaContratacion = new DateTime(2015, 10, 1),
                    Direccion = "Calle Principal 123",
                    Telefono = "123-456-7890",
                    CorreoElectronico = "juan.perez@example.com",
                    EstadoId = 1
                },
                new Empleado
                {
                    Id = 2,
                    Fotografia = "foto2.jpg",
                    Nombre = "María",
                    Apellido = "González",
                    PuestoId = 2,
                    FechaNacimiento = new DateTime(1985, 8, 25),
                    FechaContratacion = new DateTime(2017, 3, 15),
                    Direccion = "Avenida Independencia 456",
                    Telefono = "987-654-3210",
                    CorreoElectronico = "maria.gonzalez@example.com",
                    EstadoId = 1
                },
                new Empleado
                {
                    Id = 3,
                    Fotografia = "foto3.jpg",
                    Nombre = "Pedro",
                    Apellido = "Martínez",
                    PuestoId = 1,
                    FechaNacimiento = new DateTime(1982, 3, 10),
                    FechaContratacion = new DateTime(2014, 7, 20),
                    Direccion = "Paseo de la Reforma 789",
                    Telefono = "555-123-4567",
                    CorreoElectronico = "pedro.martinez@example.com",
                    EstadoId = 2
                },
                new Empleado
                {
                    Id = 4,
                    Fotografia = "foto4.jpg",
                    Nombre = "Ana",
                    Apellido = "López",
                    PuestoId = 3,
                    FechaNacimiento = new DateTime(1993, 12, 20),
                    FechaContratacion = new DateTime(2018, 5, 5),
                    Direccion = "Boulevard Juárez 321",
                    Telefono = "222-333-4444",
                    CorreoElectronico = "ana.lopez@example.com",
                    EstadoId = 2
                },
                new Empleado
                {
                    Id = 5,
                    Fotografia = "foto5.jpg",
                    Nombre = "Carlos",
                    Apellido = "Sánchez",
                    PuestoId = 2,
                    FechaNacimiento = new DateTime(1978, 6, 5),
                    FechaContratacion = new DateTime(2016, 9, 10),
                    Direccion = "Avenida Insurgentes 987",
                    Telefono = "111-222-3333",
                    CorreoElectronico = "carlos.sanchez@example.com",
                    EstadoId = 3
                }
            };

            return empleados;
        }
    }
}

