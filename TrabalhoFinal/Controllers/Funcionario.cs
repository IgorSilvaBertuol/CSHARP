

using Controllers.Base;
using Controllers.DAL;
using Models;
using System.Linq;

namespace Controllers
{
    public class Funcionario : IBaseController<CadFuncionario>
    {

        private Contexto contexto = new Contexto();

        public void Adicionar(CadFuncionario entity)
        {
            contexto.Funcionario.Add(entity);
            contexto.SaveChanges();
        }

        public CadFuncionario BuscarPorID(int id)
        {
            return contexto.Funcionario.Find(id);
        }


        public void Editar(CadFuncionario entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int id)
        {
            CadFuncionario func = BuscarPorID(id);
            if (func != null)

            {
                contexto.Funcionario.Remove(func);
                contexto.SaveChanges();
            }
        }

        public System.Collections.Generic.IList<CadFuncionario> ListarPorNome(string nome)
        {
            return contexto.Funcionario.Where(Func => Func.FuncNome == nome).ToList();
        }

        public System.Collections.Generic.IList<CadFuncionario> ListarTodos()
        {
            return contexto.Funcionario.ToList();
        }
    }
}
