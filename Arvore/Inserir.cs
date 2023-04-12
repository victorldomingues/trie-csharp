public partial class Arvore
{
    public void Inserir(string texto)
    {
        var tamanho = texto.Length;
        var raiz = Raiz;

        foreach (var caractere in texto)
        {
            var deslocamento = Deslocamento(caractere);

            if (raiz.Filhos[deslocamento] == null)
                raiz.Filhos[deslocamento] = new No();

            raiz = raiz.Filhos[deslocamento];
        }

        raiz.FimDoPrefixo = true;
    }
}