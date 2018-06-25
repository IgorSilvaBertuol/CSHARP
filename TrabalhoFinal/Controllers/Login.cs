using Controllers.DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class Login
    {
        private Contexto context = new Contexto();

        private CadFuncionario BuscaFunc (CadFuncionario entity)
        {
            return context.Funcionario.Find(entity);
        }

        
    }
}
