using App.Entities;
using App.Repositories.Interfaces;
using App.Services.Interfaces;

namespace App.Services
{
    public class AppMensagemService : IAppMensagemService
    {
        private readonly IAppMensagemRepository _repository;

        public AppMensagemService(IAppMensagemRepository repository)
        {
            _repository = repository;
        }

        public void CadastrarConta(AppMensagem mensagem)
        {
            _repository.SendMensagem(mensagem, "queue_kafka");
        }

        public void DepositarValor(AppMensagemTransaction mensagem)
        {
            _repository.PutMensagem(mensagem, "queue_depositar");
        }

        public void SacarValor(AppMensagemTransaction mensagem)
        {
            _repository.PutMensagem(mensagem, "queue_sacar");
        }
    }
}
