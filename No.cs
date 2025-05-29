using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreExercicio
{
    public class No
    {
        public int Valor { get; private set; }
        public No EsquerdoS { get; set; }
        public No DireitoB { get; set; }


        public No(int valor)
        {
            Valor = valor;
            EsquerdoS = null;
            DireitoB = null;
        }

        public override string ToString()
        {
            return Valor.ToString();
        }
    }
}