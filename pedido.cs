public class Pedido
{
    public int Id { get; set; }
    public string Status { get; set; }
    public DateTime DataEntrada { get; set; }
    public string Responsavel { get; set; }
    public Cliente Cliente { get; set; }
    public List<ItemPedido> Itens { get; set; }
    public Fornecedor Fornecedor { get; set; }
}

public class Cliente
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
}

public class ItemPedido
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public decimal Valor { get; set; }
}

public class Fornecedor
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public decimal MargemDesconto { get; set; }
    public string RegimeFiscal { get; set; }
    public string CNPJ { get; set; }
}
