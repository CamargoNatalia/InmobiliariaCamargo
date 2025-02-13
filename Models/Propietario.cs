using System.ComponentModel.DataAnnotations;

namespace InmobiliariaCamargo.Models
{
public class Propietario
    {
        [Key]
        [Display (Name ="Código")]
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public string Apellido { get; set; }    
         [Display (Name ="DNI")]
        public string Dni { get; set; } 
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}