using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas_Geométricas.Src
{
    class Forma_Base
    {
        public string Forma { get; set; }
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Forma_Base(string forma, double altura, double largura)
        {
            Forma = forma;
            Altura = altura;
            Largura = largura;
        }

        public override string ToString()
        {

            return

            ($"A área do {Forma} é de: {Altura * Largura}!");

        }
        
    }
}
