using System.Collections.Generic;
using System.Linq;
using Controllers.Base;
using Controllers.Base.DAL;
using Modelos;

namespace Controllers
{
    public class UsuariosController : IBaseController<Usuario>
    {
        private Contexto contexto = new Contexto();

        public void Adicionar(Usuario entity)
        {
            contexto.Usuarios.Add(entity);
            contexto.SaveChanges();
        }

        public Usuario BuscarPorID(int id)
        {
            return contexto.Usuarios.Find();
        }

        public void Editar(Usuario entity)
        {
            throw new System.NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<Usuario> ListarPorNome(string nome)
        {
            //LINQ
            //var usuariosComNome = from usu in contexto.Usuarios where usu.Nome == nome select usu;
            //return usuariosComNome.ToList();

            //LAMBDA
            return contexto.Usuarios.Where(usu => usu.Nome == nome).ToList();
        }

        public IList<Usuario> ListarPorNome()
        {
            throw new System.NotImplementedException();
        }

        public IList<Usuario> ListarTodos()
        {
            return contexto.Usuarios.ToList();
        }
    }
}
