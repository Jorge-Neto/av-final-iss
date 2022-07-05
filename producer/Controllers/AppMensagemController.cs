using Microsoft.AspNetCore.Mvc;
using App.Entities;
using App.Services.Interfaces;

namespace App.Publisher.Api.Controllers
{
    [Route("conta/")]
    [ApiController]
    public class AppMensagensController : ControllerBase
    {
        private readonly IAppMensagemService _service;

        public AppMensagensController(IAppMensagemService service)
        {
            _service = service;
        }

        [HttpPost("/cadastrar")]
        public void CadastrarConta(AppMensagem mensagem)
        {
            _service.CadastrarConta(mensagem);
        }
        [HttpPut("/depositar/{agencia}/{conta}/{valor}")]
        public void DepositarValor(string agencia, string conta, string valor)
        {
            AppMensagemTransaction mensagem = new AppMensagemTransaction();
            mensagem.agencia = agencia;
            mensagem.conta = conta;
            mensagem.valor = valor;

            _service.DepositarValor(mensagem);
        }
        [HttpPut("/sacar/{agencia}/{conta}/{valor}")]
        public void SacarValor(string agencia, string conta, string valor)
        {
            AppMensagemTransaction mensagem = new AppMensagemTransaction();
            mensagem.agencia = agencia;
            mensagem.conta = conta;
            mensagem.valor = valor;

            _service.SacarValor(mensagem);
        }
    }
}
