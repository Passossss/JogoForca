using System;

class Program
{
    static string palavraSecreta = "Cachorro";
    static string? palavraDescoberta;
    static int numTentativas;
    static string letrasErradas = "";

    static void Main(string[] args)
    {
        palavraDescoberta = new string('_', palavraSecreta.Length);
        numTentativas = 8;
        Console.WriteLine("BEM-VINDO AO JOGO DA FORCA");
        Console.WriteLine("==========================");
        ExibirPalavraDescoberta();

        while (numTentativas > 0 && palavraDescoberta.Contains('_'))
        {
            LetraSelecionada();
            ExibirPalavraDescoberta();
            ExibirBonecoForca();
        }

        if (palavraDescoberta == palavraSecreta)
        {
            Console.WriteLine("Parabéns, você acertou a palavra secreta!");
        }
        else
        {
            Console.WriteLine($"Você perdeu! A palavra secreta era: {palavraSecreta}");
        }
    }

    static void ExibirPalavraDescoberta()
    {
        Console.WriteLine("\nPalavra: " + palavraDescoberta);
        Console.WriteLine("Letras erradas: " + letrasErradas);
        Console.WriteLine($"Tentativas restantes: {numTentativas}");
    }

    static void ExibirBonecoForca()
    {
        switch (numTentativas)
        {
            case 6:
                break;
            case 5:
                Console.WriteLine(" |   ");
                break; 
            case 4:
                Console.WriteLine(" O   ");
                break; 
            case 3:
                Console.WriteLine(" O   ");
                Console.WriteLine(" |   ");
                break;
            case 2:
                Console.WriteLine(" O   ");
                Console.WriteLine(" |   ");
                Console.WriteLine("/    ");
                break;
            case 1:
                Console.WriteLine(" O   ");
                Console.WriteLine(" |   ");
                Console.WriteLine("/ \\  ");
                break;
            case 0:
                Console.WriteLine(" O   ");
                Console.WriteLine("/|\\ ");
                Console.WriteLine(" |   ");
                Console.WriteLine("/ \\  ");
                break;
        }
    }

    static void LetraSelecionada()
    {
        string? let;
        Console.Write("Digite uma letra: ");
        let = Console.ReadLine();
        let = let.ToLower();

        if (let.Length != 1 || !Char.IsLetter(let[0]))
        {
            Console.WriteLine("Por favor, digite apenas uma letra.");
            return;
        }

        if (letrasErradas.Contains(let) || palavraDescoberta.Contains(let))
        {
            Console.WriteLine($"Você já tentou a letra '{let}'.");
            return;
        }

        if (palavraSecreta.ToLower().Contains(let))
        {
            Console.WriteLine($"A letra '{let}' existe na palavra!");
            AtualizarPalavraDescoberta(let);
        }
        else
        {
            Console.WriteLine($"A letra '{let}' NÃO existe na palavra!");
            letrasErradas += let + " ";
            numTentativas--;
        }
    }
    static void AtualizarPalavraDescoberta(string letra)
    {
        char[] palavraArray = palavraDescoberta.ToCharArray();
        for (int i = 0; i < palavraSecreta.Length; i++)
        {
            if (palavraSecreta[i].ToString().ToLower() == letra)
            {
                palavraArray[i] = palavraSecreta[i];
            }
        }
        palavraDescoberta = new string(palavraArray);
    }
}
