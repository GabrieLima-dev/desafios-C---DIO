using _9__Utilizando_Construtores.Services;

class Program
{
    static void Main()
    {
        Console.WriteLine("");
        string nome = Console.ReadLine();

        Console.WriteLine("");
        string raca = Console.ReadLine();

        Console.WriteLine("");
        string classe = Console.ReadLine();

        Personagem personagem = new Personagem(nome, raca, classe);

        Console.WriteLine("Status:");
        personagem.ExibirStatus();
    }
}