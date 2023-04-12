public partial class Arvore
{
    public Arvore()
    {
        Raiz = new No();
    }

    public No Raiz;

    public int Deslocamento(char caractere)
    {
        if (char.IsAsciiDigit(caractere))
            return caractere - '0';

        return caractere - 'a';
    }
}
