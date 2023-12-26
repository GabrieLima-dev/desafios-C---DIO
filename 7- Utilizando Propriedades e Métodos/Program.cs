using _7__Utilizando_Propriedades_e_Métodos.Services;

class Program
{
    static void Main()
    {
        string[] valores = Console.ReadLine().Split(' '); int vmin = int.Parse(valores[0]); int vmax = int.Parse(valores[1]);
        string comandos = Console.ReadLine();

        Robo robo = new Robo(vmin, vmax);

        foreach (var comando in comandos)
        {
            switch (comando)
            {
                case 'A' or 'a':
                    robo.Acelerar();
                    break;
                case 'D' or 'd':
                    robo.Desacelerar();
                    break;
            }
        }
        Console.WriteLine(robo.VelocidadeAtual);
    }
}