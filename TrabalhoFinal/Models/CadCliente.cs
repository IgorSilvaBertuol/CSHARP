using System.ComponentModel.DataAnnotations;

namespace Models
{
   public class CadCliente
    {

        [Key]
        public int ClienteID { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

       public int Idade { get; set; }
        
        public int Telefone { get; set; }

        public bool Ativo { get; set; }

        public Conta _Conta { get; set; }

 




    }
}
