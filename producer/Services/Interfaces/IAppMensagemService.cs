using App.Entities;

namespace App.Services.Interfaces
{
    public interface IAppMensagemService
    {
        void CadastrarConta(AppMensagem mensagem);
        void DepositarValor(AppMensagemTransaction mensagem);
        void SacarValor(AppMensagemTransaction mensagem);
    }
}
