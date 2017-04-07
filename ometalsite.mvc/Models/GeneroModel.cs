using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ometalsite.mvc.Models
{
    public class GeneroModel
    {
        [Key]
        public int GeneroId { get; set; }

        [Required(ErrorMessage = @"Preencha o campo Nomeclatura!")]
        [MinLength(10, ErrorMessage = @"Campo Nomeclatura deve conter no mínimo 10 caracteres!")]
        [MaxLength(255, ErrorMessage = @"Campo Nomeclatura deve conter até 255 caracteres!")]
        public string Nomeclatura { get; set; }

        public int GeneroPaiId { get; set; }
        public virtual IEnumerable<BandaModel> Bandas { get; set; }
    }
}