using Controllers.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers
{
  public class Funcionario    {

        private Contexto contexto = new Contexto();

        private void adicionar (CadFuncionario entity)
        {
            contexto.Funcionario.Add(entity);

        }

        
    }
}
