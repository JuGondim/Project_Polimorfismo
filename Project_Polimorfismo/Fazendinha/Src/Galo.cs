using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fazendinha.Src
{
    internal class Galo : Animal
    {
        public Galo(string nome, int idade, string cor, int patas) : base(nome, idade, cor, patas)
        {

        }

        public override void Comer()
        {
            Console.WriteLine($"{Nome} milho e insetos.");
        }

        public void Atividade()
        {
            Console.WriteLine($"{Nome} está cantando! \n +" +
                "COCOROCÓÓÓÓÓ");
        }
    }
}

