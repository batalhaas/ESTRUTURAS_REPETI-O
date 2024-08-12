using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        ExibirTabuadas(1, 20);
    }

    static void ExibirTabuadas(int inicio, int fim)
    {
        for (int numero = inicio; numero <= fim; numero++)
        {
            ExibirTabuada(numero);
            // Solicita que o usuário pressione uma tecla para continuar
            Console.WriteLine("Pressione qualquer tecla para continuar para a próxima tabuada...");
            Console.ReadKey();
            Console.WriteLine(); // Adiciona uma linha em branco para separar as tabuadas
        }
    }

    static void ExibirTabuada(int numero)
    {
        Console.WriteLine($"Tabuada do número {numero}:");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}

