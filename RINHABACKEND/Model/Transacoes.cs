namespace RINHABACKEND.Model
{
    public class Transacao
    {
        public Guid transacaoID { get; set; }
        public int Valor { get; set; }
        public TipoDeConta Tipo { get; set; }
        public string Descricao { get; set; }
        public DateTime Realizada_em { get; set; }

        public Transacao(int valor, TipoDeConta tipo, string descricao, DateTime realizada_em)
        {
            Valor = valor;
            Tipo = tipo;
            Descricao = descricao;
            Realizada_em = realizada_em;
        }
    }
}