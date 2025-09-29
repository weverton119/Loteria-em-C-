using System;
using System.Linq;

class Program
{
    static void Main()
    {
        const int qtdeNumeros = 6;
        const int maxNumero = 60;

        int[] aposta = new int[qtdeNumeros];
        int[] sorteio = new int[qtdeNumeros];

        Console.WriteLine(" Loteria – Escolha seus 6 números (1 a 60):");

        // Entrada da aposta do jogador
        for (int i = 0; i < qtdeNumeros; i++)
        {
            while (true)
            {
                Console.Write($"Número {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int num) &&
                    num >= 1 && num <= maxNumero &&
                    !aposta.Contains(num))
                {
                    aposta[i] = num;
                    break;
                }
                else
                {
                    Console.WriteLine("⚠️ Número inválido ou repetido. Tente novamente.");
                }
            }
        }

        // Sorteio aleatório sem repetição
        Random rnd = new Random();
        int contador = 0;
        while (contador < qtdeNumeros)
        {
            int num = rnd.Next(1, maxNumero + 1);
            if (!sorteio.Contains(num))
            {
                sorteio[contador] = num;
                contador++;
            }
        }

        // Contagem de acertos
        int acertos = aposta.Intersect(sorteio).Count();

        // Resultado
        Console.WriteLine("\n Sua aposta: " + string.Join(", ", aposta));
        Console.WriteLine(" Números sorteados: " + string.Join(", ", sorteio));
        Console.WriteLine($"\n Você acertou {acertos} número(s)!");

        if (acertos == 6) Console.WriteLine(" Parabéns! Você ganhou na loteria!");
        else if (acertos >= 4) Console.WriteLine(" Muito bem! Você fez uma boa pontuação.");
        else Console.WriteLine(" Não foi dessa vez. Tente novamente!");
    }
}
