using System.ComponentModel.DataAnnotations;

namespace ometalsite.mvc.Models
{
    public class BandaModel
    {
        [Key]
        public int BandaId { get; set; }

        [Required(ErrorMessage = "Necessário informar o nome da banda")]
        [MinLength(2, ErrorMessage = "Nome deve conter no mínimo 2 caracteres!")]
        [MaxLength(255, ErrorMessage = "Nome deve conter no máximo 255 caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Necessário informar o gênero da banda")]
        public int GeneroId { get; set; }

        public virtual GeneroModel Genero { get; set; }
    }
}