using System.ComponentModel.DataAnnotations;

namespace ProjetoCinema.Models
{
    public class Sala
    {
        public int SalaId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name ="Quantidade de Assentos")]
        public int QuantidadeAssentos { get; set; }

        [Display(Name ="Disponível?")]
        public bool Disponivel { get; set; }




    }
}
