using System;

class Program
{
    static void Main()
    {
        int soma = SomarNumeros(1, 100);
        ExibirResultado(soma);
    }

    static int SomarNumeros(int inicio, int fim)
    {
        int soma = 0;

        // Loop para somar os números de 'inicio' a 'fim'
        for (int i = inicio; i <= fim; i++)
        {
            soma += i;
        }

        return soma;
    }

    static void ExibirResultado(int soma)
    {
        // Exibe a soma total
        Console.WriteLine($"A soma dos números inteiros positivos de 1 a 100 é: {soma}");
    }
}
