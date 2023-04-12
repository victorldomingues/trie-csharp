public partial class Arvore
{
    public bool Buscar(string texto)
    {
        var tamanho = texto.Length;
        var raiz = Raiz;

        foreach (var caractere in texto)
        {
            var deslocamento = Deslocamento(caractere);

            if (raiz.Filhos[deslocamento] == null)
                return false;

            raiz = raiz.Filhos[deslocamento];
        }
        return raiz.FimDoPrefixo;
    }

}