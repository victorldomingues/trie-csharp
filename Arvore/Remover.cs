public partial class Arvore
{
    public void Remover(string texto)
    {
        var tamanho = texto.Length;
        var raiz = Raiz;

        foreach (var caractere in texto)
        {
            var deslocamento = Deslocamento(caractere);

            if (raiz.Filhos[deslocamento] == null)
                return;

            raiz = raiz.Filhos[deslocamento];
        }
        raiz.FimDoPrefixo = false;
    }
}