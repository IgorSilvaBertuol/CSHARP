

namespace Models
{
    public class Conta
    {

        public CadCliente Clinte { get; set; }

        public CadProdutos Produto { get; set; }

        public float total { get; set; }

        public bool ativo { get; set; }
    }
}
