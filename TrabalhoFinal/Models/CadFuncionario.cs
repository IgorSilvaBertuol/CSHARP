

using System.ComponentModel.DataAnnotations;

namespace Models
{
    class CadFuncionario
    {

        [Key]
        public int FuncID { get; set; }

        public int FuncCOD { get; set; }

        public string FuncNome { get; set; }

        public string Senha { get; set; }

    }
}
