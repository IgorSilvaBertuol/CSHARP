using System.ComponentModel.DataAnnotations;


namespace Models
{
    class CadProdutos
    {
            [Key]
            public int ProdID { get; set; }

            public string ProdNome { get; set; }

            public int ProdCod { get; set; }

            public float ProdPreço { get; set; }

    }
}
