using System.ComponentModel.DataAnnotations;

namespace ProjetoCinema.Models
{
    public class Compra
    {
        public int CompraId { get; set; }

        
        public int SessaoId { get; set; }


        public bool MeiaEntrada { get; set; }
        
        [RegularExpression("^[0-9]{11}$", ErrorMessage = "Esse não é um CPF válido")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        public string Cpf { get; set; }

        public Sessao Sessao { get; set; }


    }
}
