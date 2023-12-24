using _6__Primeiro_Desafio_com_POO.Service;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("");
        string nome = Console.ReadLine();

        Console.WriteLine("");
        int idade = int.Parse(Console.ReadLine());

        Pessoa pessoa = new Pessoa(nome, idade);

       
        Console.WriteLine($"Nome: {pessoa.GetNome()}, Idade: {pessoa.GetIdade()}");
    }
}