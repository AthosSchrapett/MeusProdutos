namespace MeusProdutos.Models.DTOs.Update;

public record ProdutoUpdateDTO(
    int Id,
    decimal Valor,
    string Descricao
);
