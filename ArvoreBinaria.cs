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



        public void Inserir(int Valor)
        {

            if (_raiz == null)
            {
                No no = new No(Valor);
                _raiz = no;

            }

            else
            {
                bool inserted = false;
                No comparer = _raiz;
                while (inserted == false)
                {
                    if (Valor > comparer.Valor)
                    {
                        if (comparer.DireitoB == null)
                        {
                            comparer.DireitoB = new No(Valor);
                            inserted = true;

                        }

                        else if (comparer.Valor == Valor)
                        {
                            Console.WriteLine("Valor Duplicado");

                        }

                        else
                        {
                            comparer = comparer.DireitoB;
                        }

                    }

                    else
                    {
                        if (comparer.EsquerdoS == null)
                        {
                            comparer.EsquerdoS = new No(Valor);
                            inserted = true;

                        }


                        else if (comparer.Valor == Valor)
                        {
                            Console.WriteLine("Valor Duplicado");

                        }

                        else
                        {
                            comparer = comparer.EsquerdoS;
                        }


                    }

                }

            }

        }


        public void MostrarArvore()
        {

            if (_raiz == null)
            {
                Console.WriteLine("Arvore Vazia");


            }
            else
            {
                No comparer = _raiz;
                bool buscar = true;
                while (buscar == true)
                {
                    Console.WriteLine($"     |{comparer}|");
                    Console.Write(comparer.EsquerdoS != null ? $" | {comparer.EsquerdoS} | ":" | Nulo | ");
                    Console.Write(comparer.DireitoB != null ? $" | {comparer.DireitoB} | ":" | Nulo | ");
                    Console.WriteLine("\n Selecione o lado que quer percorrer:(E/D) ou S para sair");
                    string input = Console.ReadLine().ToLower();
                    switch (input)
                    {
                        case "e":
                            if (comparer.EsquerdoS != null)
                            {
                                Console.WriteLine("Esquerdo selecionada");
                                comparer = comparer.EsquerdoS;
                            }
                            else
                                Console.WriteLine("Referencia Nula");
                            break;

                        case "d":
                            if (comparer.DireitoB != null)
                            {
                                Console.WriteLine("Direito selecionada");
                                comparer = comparer.DireitoB;
                            }
                            else
                                Console.WriteLine("Referencia Nula");
                            break;

                        case "s":
                            Console.WriteLine("Saindo");
                            buscar = false;
                            break;

                        default:
                            Console.WriteLine("Valor invalido");
                            break;
                    }
                }
            }



        }




        public bool Busca(int Valor)
        {
            

            No comparer = _raiz;
            while (comparer != null)
            {

            if (comparer.Valor == Valor)
            {
                    Console.WriteLine("Valor Encontrado");
                    return true;
                }
            else
            {
                if (Valor > comparer.Valor)
                {
                    comparer = comparer.DireitoB;
                }

                else
                {
                    comparer = comparer.EsquerdoS;

                }
            }

        }
            Console.WriteLine("Valor não encontrado");
            return false;
        }
    }
}

    


