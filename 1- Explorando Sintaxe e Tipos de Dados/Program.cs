class Program
{
    static void Main(string[] args)
    {

        // TODO: Declare as variáveis para guardar as informações de nome, email e senha:
        string registroEmail;
        string registoNome;
        string senha;

        // Obtém o email e nome do usuário a partir da entrada do console
        Console.WriteLine("Digite o seu email: ");
        registroEmail = Console.ReadLine();
        Console.WriteLine("Digite o seu nome: ");
        registoNome = Console.ReadLine();
        Console.WriteLine("Digite a sua senha: ");
        char[] senhaChars = Console.ReadLine().ToCharArray();


        // TODO: Imprima a mensagem formatada com o nome do usuário e o email de registro:
        Console.WriteLine($"{registoNome}, verifique o email: {registroEmail} para ativar.");


    }
}