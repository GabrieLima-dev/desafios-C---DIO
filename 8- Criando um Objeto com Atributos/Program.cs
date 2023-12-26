using _8__Criando_um_Objeto_com_Atributos.Services;

class Program
{
    static void Main()
    {
        Console.WriteLine("");
        string nome = Console.ReadLine();

        Console.WriteLine("");
        string nacionalidade = Console.ReadLine();

        Console.WriteLine("");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine("");
        string posicao = Console.ReadLine();

        Jogador jogador = new Jogador(nome, nacionalidade, idade, posicao);

        Console.WriteLine("Jogador criado!");
        Console.WriteLine($"{nome} \n {nacionalidade} \n {idade} \n Posição: {posicao}");
    }
}