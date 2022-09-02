using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fazendinha.Src
{
    internal class Porco : Animal
    {
        public Porco(string nome, int idade, string cor, int patas) : base(nome, idade, cor, patas)
        {

        }

        public override void Comer()
        {
            Console.WriteLine($"{Nome} está comendo ração com frutas e verduras.");
        }

        public void Atividade()
        {
            Console.WriteLine($"{Nome} está rolando na lama!");
        }
    }
}

