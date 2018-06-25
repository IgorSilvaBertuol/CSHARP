
using System.Collections.Generic;
using System.Linq;
using Controllers.Base;
using Controllers.DAL;
using Models;

namespace Controllers.Base
{
    public  class ContaController
    {

       private Contexto contexto = new Contexto();

        public CadCliente BuscarCPF (string cpf)
        {
            return contexto.Cliente.Find(cpf);   

        }

        public CadProdutos BuscaProduto (int cod)
        {


            return contexto.Produtos.Find(cod);
        }

        public void _Conta (string cpf, int cod)
        {
            float total = 0;
            CadCliente cont = BuscarCPF(cpf);
            CadProdutos prod = BuscaProduto(cod);

           
            if (cont != null && prod != null) 
            {
                total = cont._Conta.total + prod.ProdPreço;
                cont._Conta.total = total;

                contexto.SaveChanges();
            }

        }

   
        
    }
}
