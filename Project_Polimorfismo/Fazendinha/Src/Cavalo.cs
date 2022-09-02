using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fazendinha.Src
{
    internal class Cavalo : Animal
    {
        public Cavalo(string nome, int idade, string cor, int patas) : base(nome, idade, cor, patas)
        {

        }
        public override void Comer()
        {
            Console.WriteLine($"{Nome} está comendo feno e cereais.");
        }

        public void Atividade()
        {
            Console.WriteLine($"{Nome} está trotando!");
        }
    }
}
