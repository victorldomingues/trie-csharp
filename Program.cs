// See https://aka.ms/new-console-template for more information
using System;

var arvore = new Arvore();

while (true)
{

    foreach (var item in Enum.GetValues(typeof(Acao))
    .Cast<Acao>())
    {
        Console.WriteLine($"Ação: {item.GetHashCode()} - {item}");
    }

    var linha = Console.ReadLine();

    Enum.TryParse<Acao>(linha, true, out var acao);
    Console.WriteLine(acao);

    switch (acao)
    {
        case Acao.Inserir:
            {
                Console.WriteLine("Inserir - Informe a palavra:");
                linha = Console.ReadLine();
                arvore.Inserir(linha);
                break;
            }

        case Acao.Buscar:
            {
                Console.WriteLine("Buscar - Informe a palavra:");
                linha = Console.ReadLine();
                var existe = arvore.Buscar(linha);
                Console.WriteLine($"Existe {linha}: {existe}");
                break;
            }
        case Acao.Remover:
            {
                Console.WriteLine("Remover - Informe a palavra:");
                linha = Console.ReadLine();
                arvore.Remover(linha);
                break;
            }
        case Acao.Sair:
            return;
    }

}