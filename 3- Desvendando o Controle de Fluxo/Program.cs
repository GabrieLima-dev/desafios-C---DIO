using System;

class Program
{
    static void Main()
    {
    // Solicita ao usuário os limites inferiores e superiores
    Console.WriteLine("");
    int limiteInferior = int.Parse(Console.ReadLine());
    Console.WriteLine("");
    int limiteSuperior = int.Parse(Console.ReadLine());

    // Variável para acumular a soma dos números pares
    int somaPares = 0;

    // TODO: Crie um Loop para percorrer os números no intervalo
    for (int i = limiteInferior; i <= limiteSuperior; i++){
        if (i % 2 == 0){
            somaPares = i + somaPares;
        }
        
    }      

    // Exibe o resultado
    Console.WriteLine($"A soma dos numeros pares de {limiteInferior} a {limiteSuperior} e: {somaPares}");
    }
}