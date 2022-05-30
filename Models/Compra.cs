namespace ProjetoCinema.Models
{
    public class Compra
    {
        public int CompraId { get; set; }

        
        public int SessaoId { get; set; }


        public bool MeiaEntrada { get; set; }

        public Sessao Sessao { get; set; }


    }
}
