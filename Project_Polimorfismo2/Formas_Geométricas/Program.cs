using Formas_Geométricas.Src;
using System;

namespace Formas_Geométricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            
            do
            {

                Console.WriteLine("Use este app para poder calcular a área das figuras abaixo!");
                Console.WriteLine("Digite a figura desejada: \n" +
                    "0 - Quadrado \n" +
                    "1 - Retângulo \n" +
                    "2 - Triângulo \n");
                int figura = int.Parse(Console.ReadLine());

                switch (figura)
                {
                    case 0:

                        Console.WriteLine("Digite o primeiro valor: ");
                        double valor1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo valor: ");
                        double valor2 = double.Parse(Console.ReadLine());

                        var quadrado = new Quadrado("Quadrado", valor1, valor2);

                        Console.WriteLine(quadrado.ToString());
                        quadrado.Formato();

                        break;

                    case 1:

                        Console.WriteLine("Digite o primeiro valor: ");
                        valor1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo valor: ");
                        valor2 = double.Parse(Console.ReadLine());

                        var retângulo = new Retângulo("Retângulo", valor1, valor2);

                        Console.WriteLine(retângulo.ToString());
                        break;

                    case 2:
                        Console.WriteLine("Digite o primeiro valor: ");
                        valor1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo valor: ");
                        valor2 = double.Parse(Console.ReadLine());

                        var triângulo = new Triângulo("Triângulo", valor1, valor2);

                        Console.WriteLine(triângulo.ToString());
                        break;

                    default:

                        Console.WriteLine("Entre com uma opção válida!");
                        break;
                }

                Console.WriteLine("Deseja realizar outra operação? \n" +
                            "0 - Sim \n" +
                            "1 - Não");
                cont = int.Parse(Console.ReadLine());
            }

            while (cont != 1);
            Console.WriteLine("Até a próxima!");
        }
    }
}
