using Microsoft.AspNetCore.Mvc;
using RINHABACKEND.Data;
using RINHABACKEND.Model;

namespace RINHABACKEND.Services
{
    public class Service
    {
        private readonly Databasecontext _databasecontext;
        public Service(Databasecontext databasecontext)
        {
            _databasecontext = databasecontext;
        }

        public Saldo GetSaldo(Guid id)
        {
            var conta = _databasecontext.Saldos.FirstOrDefault(c => c.Id == id);
            return conta;
        }

        public void CriarConta(Saldo saldo)
        {
            _databasecontext.Add(saldo);
            _databasecontext.SaveChanges();
        }

        public void CriarTransacao(int valor, string descricao, TipoDeConta tipo)
        {
            Transacao transacao = new Transacao(valor, tipo, descricao, DateTime.Now);

            _databasecontext.Add(transacao);
            _databasecontext.SaveChanges();
        }
    };
}
