using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fazendinha.Src
{
    internal class Cabra : Animal
    {
        public Cabra(string nome, int idade, string cor, int patas) : base(nome, idade, cor, patas)
        {

        }

        public override void Comer()
        {
            Console.WriteLine($"{Nome} está pastando.");
        }

        public void Atividade()
        {
            Console.WriteLine($"{Nome} está pulando pela fazenda!");
        }
    }
}
