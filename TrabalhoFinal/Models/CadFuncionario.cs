

using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class CadFuncionario
    {


       
        

        [Key]
        public int FuncID { get; set; }

        public string FuncNome { get; set; }

        public string Senha { get; set; }

        public string Funcao { get; set; }


    }

  
}

