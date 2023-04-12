public class Menu
{
    private readonly Arvore _arvore;
    private readonly IEnumerable<Acao> _acoes;

    public Menu()
    {
        _arvore = new();
        _acoes = Enum.GetValues(typeof(Acao))
                     .Cast<Acao>();
    }

    public void Imprimir()
    {
        foreach (var item in _acoes)
            Console.WriteLine($"Ação: ({item.GetHashCode()}) - {item}");

        Console.WriteLine("\nInforme o código da ação:");
    }

    public void Inserir(string linha)
        => _arvore.Inserir(linha);

    public void Buscar(string linha)
        => Console.WriteLine($"Existe {linha}: {_arvore.Buscar(linha)}");

    public void Remover(string linha)
        => _arvore.Remover(linha);

    public void Executar(Acao acao)
    {
        if (acao == Acao.Sair)
            Environment.Exit(0);

        Console.WriteLine($"\nAção {acao} - Informe a palavra:");
        var linha = Console.ReadLine().ToLowerInvariant();
        var method = typeof(Menu).GetMethod(acao.ToString());
        method.Invoke(this, new object[] { linha });
        Console.WriteLine();

    }
}