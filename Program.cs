using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreExercicio
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            ArvoreBinaria tree = new ArvoreBinaria();
            tree.MostrarRaiz();
            tree.Inserir(10);
            tree.Inserir(20);
            tree.Inserir(5);
            tree.Inserir(7);
            tree.Inserir(35);
            tree.MostrarRaiz();
            tree.MostrarArvore();
            Console.ReadLine();
        }
    }

   
 }


   






