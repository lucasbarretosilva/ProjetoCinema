using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCinema.Models
{
    public class Sessao
    {
        public int SessaoId { get; set; }

        [Required(ErrorMessage ="Campo Obrigatório")]  
        [Display(Name ="Número da Sessão")]
        public int NumeroSessao { get; set; }

        [Display(Name ="Filme")]
        
        public int FilmeId { get; set; }

        [Display(Name = "Sala")]
        public int SalaId { get; set; }

        [Required(ErrorMessage ="Campo Obrigatório")]
        [Display(Name = "Horário de Início")]
        public DateTime Horario { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Horário de Término")]
        public DateTime HorarioFinal { get; set; }

        public virtual Filme Filme { get; set; }

        public virtual Sala Sala { get; set; }



    }
}
