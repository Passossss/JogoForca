class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("BEM-VINDO AO JOGO DA FORCA");
        Console.WriteLine("==========================");
        LetraSelecionada();
    }
    static string palavraSecreta = "Cachorro";
    static int numTentativas = palavraSecreta.Length;
    public static void LetraSelecionada()
    {
        string? let;
        Console.WriteLine("Digite uma letra para o jogo da forca: ");
        let = Console.ReadLine();
        let = let.ToLower();
        if (palavraSecreta.ToLower().Contains(let))
        {
            Console.WriteLine("A letra {0} existe na palavra secreta!", let);
        }
        else
        {
            Console.WriteLine("A letra {0} NÃO existe na palavra!", let);
        }
    }



}