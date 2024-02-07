using Microsoft.AspNetCore.Mvc;
using RINHABACKEND.Data;
using RINHABACKEND.Model;
using RINHABACKEND.Services;

namespace RINHABACKEND.Controllers
{
    [ApiController]
    [Route("/clientes")]
    public class Controller : ControllerBase
    {
        private readonly Databasecontext _db;
        private readonly Service _contaService;
        public Controller(Databasecontext db, Service contaservice)
        {
            _db = db;
            _contaService = contaservice;
        }


        [HttpGet]
        [Route("{id}/extrato")]
        public IActionResult GetSaldo(Guid id)
        {
            if (id == Guid.Empty)
            {
                return NotFound();
            }
            Saldo saldo = _contaService.GetSaldo(id);

            if (saldo == null)
            {
                return NotFound();
            }

            return Ok(saldo);
        }

        [HttpPost]
        [Route("/clientes/{id}/transacoes")]
        public IActionResult PostTransacao(Saldo saldo) 
        { }


    }
}
