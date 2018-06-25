using Controllers.Base;
using Controllers.DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
   public class ProdutoController : IBaseController <CadProdutos>
    {

        Contexto contexto = new Contexto();

        public void Adicionar(CadProdutos entity)
        {
            contexto.Produtos.Add(entity);
            contexto.SaveChanges();
        }

        public CadProdutos BuscarPorCod(int cod)
        {
            return contexto.Produtos.Find(cod);
        }

        public CadProdutos BuscarPorID(int id)
        {
            return contexto.Produtos.Find(id);
        }

        public void Editar(CadProdutos entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();

        }

        public void Excluir(int cod)
        {
            CadProdutos prod = BuscarPorCod(cod);
            if (prod != null)
            {
            contexto.Produtos.Remove(prod);
                contexto.SaveChanges();

            }
        }

        public IList<CadProdutos> ListarPorNome(string nome)
        {
            return contexto.Produtos.Where(prod => prod.ProdNome == nome).ToList(); 
        }

        public IList<CadProdutos> ListarTodos()
        {
            return contexto.Produtos.ToList();
        }
    }
}
