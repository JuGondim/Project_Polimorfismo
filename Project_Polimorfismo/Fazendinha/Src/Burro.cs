using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fazendinha.Src
{
    internal class Burro : Animal
    {
        public Burro(string nome, int idade, string cor, int patas) : base(nome, idade, cor, patas)
        {

        }

        public override void Comer()
        {
            Console.WriteLine($"{Nome} está comendo palha e feno.");
        }

        public void Atividade()
        {
            Console.WriteLine($"{Nome} está empacado no estábulo!");
        }
    }
}
