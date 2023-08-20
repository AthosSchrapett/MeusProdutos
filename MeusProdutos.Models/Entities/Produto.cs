namespace MeusProdutos.Models.Entities
{
    public class Produto
    {
        public int Id { get; private set; }
        public decimal Valor { get; private set; }
        public string? Descricao { get; private set; }
        public DateTime? CreatedDate { get; private set; }
        public DateTime? UpdatedDate { get; private set; }

        public Produto(decimal valor, string? descricao)
        {
            Valor = valor;
            Descricao = descricao;
            CreatedDate = DateTime.UtcNow;
        }

        public void Update(decimal valor, string? descricao)
        {
            Valor = valor;
            Descricao = descricao;
            UpdatedDate = DateTime.UtcNow;
        }
    }
}
