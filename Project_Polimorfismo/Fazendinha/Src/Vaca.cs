using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fazendinha.Src
{
    internal class Vaca : Animal
    {
        public Vaca(string nome, int idade, string cor, int patas) : base(nome, idade, cor, patas)
        {

        }

        public override void Comer()
        {
            Console.WriteLine($"{Nome} está comendo capim.");
        }

        public void Atividade()
        {
            Console.WriteLine($"{Nome} está sendo ordenhada!");
        }
    }
}

