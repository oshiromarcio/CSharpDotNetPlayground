using Newtonsoft.Json;

namespace ExemploFundamentos.Common.Models
{
    public class Venda
    {
        public int Id { get; set; }

        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }

        public Venda(int id, string produto, decimal preco, DateTime dataVenda)
        {
            this.Id = id;
            this.Produto = produto;
            this.Preco = preco;
            this.DataVenda = dataVenda;
        }
    }
}