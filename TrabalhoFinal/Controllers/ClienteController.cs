using System.Collections.Generic;
using System.Linq;
using Controllers.Base;
using Controllers.DAL;
using Models;

namespace Controllers
{
    public class ClienteController : IBaseController<CadCliente>
    {
        private Contexto contexto = new Contexto();

        public void Adicionar(CadCliente entity)
        {
            contexto.Cliente.Add(entity);
            contexto.SaveChanges();

        }

        public CadCliente BuscarPorID(int id)
        {
            return contexto.Cliente.Find(id);
        }

        public void Editar(CadCliente entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int id)
        {
            CadCliente cli = BuscarPorID(id);

            if (cli != null)
            {
                contexto.Cliente.Remove(cli);
                contexto.SaveChanges();
            }


        }

        public IList<CadCliente> ListarPorNome(string nome)
        {
            return contexto.Cliente.Where(usu => usu.Nome == nome).ToList();
        }

        public IList<CadCliente> ListarTodos()
        {
            return contexto.Cliente.ToList();
        }
    }
}
