using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }
        [Display (Name = "País")]
        [MaxLength(50, ErrorMessage = "El campo {} debe tener máximo {1} Caractéres")]
        [Required (ErrorMessage =" El campo {} es obligatorio")]
        public string  Name { get; set; }
    }
}
