using System.ComponentModel.DataAnnotations;

namespace Models
{
    class CadCliente
    {

        [Key]
        public int ClienteID { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }

        public int Idade { get; set; }
        
        public int Telefone { get; set; }

        public int Celular { get; set; }




    }
}
