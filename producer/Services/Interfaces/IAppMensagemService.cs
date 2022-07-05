using App.Entities;

namespace App.Services.Interfaces
{
    public interface IAppMensagemService
    {
        void SendMensagem(AppMensagem mensagem);
    }
}
