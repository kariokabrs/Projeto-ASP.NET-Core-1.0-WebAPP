using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreSergio.Models
{
    public class Cliente
    {
        public int id { get; set; }
        [Required]
        [MinLength(2),MaxLength(80)]
        [DisplayName("Cliente Nome:")]
        public string nome { get; set; }
        [Required]
        [MaxLength(2)]
        [DisplayName("Cliente Idade:")]
        public int idade { get; set; }
    }
}
