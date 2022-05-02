using GerenciadoDeTarefas.Models;
using System;

namespace GerenciadoDeTarefas.Repository.Impl
{
    public class UsuarioRepositoryImpl : IUsuarioRepository
    {
        private readonly GerenciadoDeTarefasContext _contexto;
        public UsuarioRepositoryImpl(GerenciadoDeTarefasContext contexto)
        {
            _contexto = contexto;
        }
        public void Salvar(Usuario usuario)
        {
            _contexto.Usuario.Add(usuario);
            _contexto.SaveChanges();
        }
    }
}
