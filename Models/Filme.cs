using System.ComponentModel.DataAnnotations;

namespace ProjetoCinema.Models
{
    public class Filme
    {
        public int FilmeId { get; set; }

        [Required(ErrorMessage ="Campo Obrigatório")]
        [Display(Name="Filme")]
        public string FilmeNome { get; set;}
        
        [Display(Name="Gênero")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Genero { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name="Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]

        public bool Legendado { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public bool Dublado { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name ="Preço")]
        [DataType(DataType.Currency)]
        public double Preco { get; set; }

    }
}
