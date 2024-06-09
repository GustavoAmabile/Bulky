using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Bulky.Models
{
    public class Agent
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Nome")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Número")]
        [Range(1, 150, ErrorMessage = "Número do Operador must be between 1-150")]
        public int Number { get; set; }

        [Required]
        [DisplayName("Setor")]
        public string Team {  get; set; }

        [Required]
        [DisplayName("Disponibilidade")]
        public bool IsAvailable { get; set; }
    }
}
