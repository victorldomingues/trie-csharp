// See https://aka.ms/new-console-template for more information
using System;

var arvore = new Arvore();

while (true)
{
    Console.WriteLine("Ação 0 - Sair");
    Console.WriteLine("Ação 1 - Inserir");
    Console.WriteLine("Ação 2 - Buscar");
    var acao = Console.ReadLine();

    if (acao == "0")
        return;
    else if (acao == "1")
    {
        Console.WriteLine("Inserir: Informe a palavra:");
        acao = Console.ReadLine();
        arvore.Inserir(acao);
    }
    else if (acao == "2")
    {
        Console.WriteLine("Buscar: Informe a palavra:");
        acao = Console.ReadLine();
        var existe = arvore.Buscar(acao);
        Console.WriteLine($"Exites: {existe}");
    }

}