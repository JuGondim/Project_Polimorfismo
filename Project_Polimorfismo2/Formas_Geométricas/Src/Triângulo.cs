using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas_Geométricas.Src
{
    internal class Triângulo : Forma_Base
    {
        public Triângulo(string forma, double altura, double largura) : base(forma, altura, largura)
        {

        }

        public void Formato()
        {
            Console.WriteLine($"O {Forma} tem 3 lados.");
        }

        
    }
}
