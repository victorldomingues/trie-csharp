# Estrutura de dados Trie (prefix tree) 

 Estrutura de dados Trie implementada em C# e .NET 7

### Nó (No.cs)

```csharp
public class No
{
    public No[] Filhos = new No[26];
    public bool FimDoPrefixo { get; set; }
}
```

### Arvore (Arvore.cs)

```csharp
public class Arvore
{
    public Arvore()
    {
        Raiz = new No();
    }

    public No Raiz;

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

    public int Deslocamento(char caractere)
    {
        if (char.IsAsciiDigit(caractere))
            return caractere - '0';

        return caractere - 'a';
    }
}
```


### Executar

```bash
dotnet run .\Program.cs
```