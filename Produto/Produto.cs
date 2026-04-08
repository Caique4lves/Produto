class Produto
{
    public string Nome { get; set; }
    private int quantidadeEstoque;

    public Produto(string nome, int qtdEstoque)
    {
        Nome = nome;
        quantidadeEstoque = qtdEstoque;
    }

    public void Retirar(int quantidade)
    {
        if (quantidadeEstoque > quantidade)
        {
            quantidadeEstoque -= quantidade;
            Console.WriteLine("Você retirou {0} {1}!", quantidade, Nome);
        }
        else
        {
            Console.WriteLine("Erro: Não foi possível retirar {0} {1}, pois temos apenas {2} em estoque!", quantidade, Nome, quantidadeEstoque);
        }
    }

    public void ExibirEstoque()
    {
        Console.WriteLine("\nEstoque atual: {0} {1}", quantidadeEstoque, Nome);
    }
}