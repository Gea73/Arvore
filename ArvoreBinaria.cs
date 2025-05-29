using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreExercicio
{
    public class ArvoreBinaria
    {

        private No _raiz { get; set; }

        public void MostrarRaiz()
        {
            if (_raiz != null)
            {
                Console.WriteLine($"Valor da raiz :{_raiz.Valor}");
            }
            else
                Console.WriteLine("Raiz Vazia");
        }

        public void MostrarArvore()
        {

        }



    }
 }

    


