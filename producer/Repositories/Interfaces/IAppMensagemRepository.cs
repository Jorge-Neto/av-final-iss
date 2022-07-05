using App.Entities;

namespace App.Repositories.Interfaces
{
    public interface IAppMensagemRepository
    {
        Task SendMensagem(AppMensagem mensagem, String queue);
        Task PutMensagem(AppMensagemTransaction mensagem, String queue);
    }
}
