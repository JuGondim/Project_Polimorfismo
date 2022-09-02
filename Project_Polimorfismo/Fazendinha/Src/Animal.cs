using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fazendinha.Src
{
    internal class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cor { get; set; }
        public int Patas { get; set; }

        public Animal(string nome, int idade, string cor, int patas)
        {
            Nome = nome;
            Idade = idade;
            Cor = cor;
            Patas = patas;
        }

        public virtual void Comer()
        {
            Console.WriteLine($"{Nome} está comendo");
        }
        public void Dormir()
        {
            Console.WriteLine($"{Nome} está a mimir");
        }
    }
}
