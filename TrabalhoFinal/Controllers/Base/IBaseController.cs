using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Base
{
    class IBaseController<T> where T : class
    {

        void Adicionar (T entity);
        IList<T> Listar

    }
}
