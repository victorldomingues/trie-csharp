// See https://aka.ms/new-console-template for more information

var menu = new Menu();

while (true)
{
    menu.Imprimir();
    var linha = Console.ReadLine();
    Enum.TryParse<Acao>(linha, true, out var acao);
    menu.Executar(acao);
}