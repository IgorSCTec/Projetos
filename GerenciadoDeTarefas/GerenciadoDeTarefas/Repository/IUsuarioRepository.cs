using GerenciadoDeTarefas.Models;

namespace GerenciadoDeTarefas.Repository
{
    public interface IUsuarioRepository
    {
        public void Salvar(Usuario usuario);
    }
}
