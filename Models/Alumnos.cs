using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MVC5.Models
{
    public class Alumnos : BaseModel
    {
        #region Propiedades
        [Key]
        public int AlumnoId { get; set; }
        [NotNull]
        [Required(ErrorMessage = "Nombres es requeridos.")]
         
        // Propiedades requeridas
        public string Nombres { get; set; }
        [NotNull]
        [Required(ErrorMessage = "Apellidos es requeridos.")]
        public string Apellidos { get; set; }
        [NotNull]
        [Required(ErrorMessage = "Edad es requeridos.")]
        public int Edad { get; set; }
        [NotNull]
        [Required(ErrorMessage = "Carnet es requeridos.")]
        public string Carnet { get; set; }
        [Required(ErrorMessage = "Cantidad de materias es requerido.")]
        public int CantidadMaterias { get; set; }
        [Required(ErrorMessage = "Ciclo es requeridos.")]
        public int Ciclo { get; set; }
        [Required(ErrorMessage = "Fecha de nacimiento es requeridos.")]
        public DateTime FechaNacimiento { get; set; }
        [NotMapped]
        
        public string NombreCompleto { get; set; }

        #endregion
        public Alumnos()
        {
            FechaNacimiento = DateTime.Now.Date;
            IsActive = true;
            Created = DateTime.Now;
            CreatedBy = "ADMIN";
        }

        // Constructor que inicializa todas las propiedades requeridas
        public Alumnos(string nombres, int edad, string apellidos, DateTime fechaNacimiento)

        {
            // Asignación de las propiedades requeridas
            Nombres = nombres;
            Edad = edad; // Asigna el valor de 'nombres' a la propiedad 'Nombres'
            Apellidos = apellidos;   // Asigna el valor de 'apellidos' a la propiedad 'Apellidos'
                          
            FechaNacimiento = fechaNacimiento;  // Asigna el valor de 'fechaNacimiento' a la propiedad 'FechaNacimiento'
                      // Asigna el valor de 'carnet' a la propiedad 'Carnet'
            NombreCompleto = $"{nombres} {apellidos}"; // Asigna el valor a 'NombreCompleto'
        }
    }
}

    

