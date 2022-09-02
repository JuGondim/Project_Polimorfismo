using System;
using Fazendinha.Src;

namespace Fazendinha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;

            var Burro = new Burro("Geraldinho", 15, "Cinza", 4);
            var Cabra = new Cabra("Judite", 8, "Vermelha", 4);
            var Cavalo = new Cavalo("Brito", 14, "Preto", 4);
            var Galinha = new Galinha("Greta", 3, "Marrom", 2);
            var Galo = new Galo("Vitu", 2, "Azul", 2);
            var Porco = new Porco("Beto", 10, "Rosa", 4);
            var Vaca = new Vaca("Frida", 12, "Malhada", 4);

            Console.WriteLine("Olá, bem vinda(o) a sua Fazendinha! \n" +
                "Gostaria de acompanhar as atividades diárias de seus animais? \n" +
                "0 - Sim \n" +
                "1 - Não \n");
            int onoff = int.Parse(Console.ReadLine());

            if (onoff == 0)
            {
                do
                { 
                Console.WriteLine("Escolha o animal que deseja acompanhar: \n" +
                    "0 - Burro \n" +
                    "1 - Cabra \n" +
                    "2 - Cavalo \n" +
                    "3 - Galinha \n" +
                    "4 - Galo \n" +
                    "5 - Porco \n" +
                    "6 - Vaca \n");
                int opcoes = int.Parse(Console.ReadLine());

                    switch (opcoes)
                    {
                        case 0: 
                            Burro.Atividade();
                            Burro.Comer();
                            Burro.Dormir();
                            break;
                        case 1:
                            Cabra.Atividade();
                            Cabra.Comer();
                            Cabra.Dormir();
                            break;
                        case 2:
                            Cavalo.Atividade();
                            Cavalo.Comer();
                            Cavalo.Dormir();
                            break;
                        case 3:
                            Galinha.Atividade();
                            Galinha.Comer();
                            Galinha.Dormir();
                            break;
                        case 4:
                            Galo.Atividade();
                            Galo.Comer();
                            Galo.Dormir();
                            break;
                        case 5:
                            Porco.Atividade();
                            Porco.Comer();
                            Porco.Dormir();
                            break;
                        case 6:
                            Vaca.Atividade();
                            Vaca.Comer();
                            Vaca.Dormir();
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
            else
            {
                Console.WriteLine("Até a próxima!");
            }
        }
    }
}
