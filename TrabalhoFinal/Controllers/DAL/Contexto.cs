using Models;
using System.Data.Entity;

namespace Controllers.DAL
{
    class Contexto : DbContext 
    {
        public Contexto() : base("StrConn")
        {
            
        }

    }
}
