using Models;
using System;
using System.Data.Entity;

namespace Controllers.DAL
{
    class Contexto : DbContext 
    {
        public Contexto() : base("StrConn")
        {
            
        }

           public DbSet<CadCliente> Cliente { get; set; }
           
            public DbSet<CadFuncionario> Funcionario { get; set; }

            public DbSet<CadProdutos> Produtos { get; set; }

            public DbSet<Conta> Conta { get; set; }

      
    }
}
