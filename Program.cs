using System;
using System.Collections.Generic;

namespace P4_listas_y_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = new string[] {"1" , "2" , "3" , "4" , "5" , null};

            for (int i = 0; i < 6; i++)
            {
                Console.Write(numeros[i] + " ");
            }
            //cambios
            numeros[1] = "6";

            numeros[4] = "7";
            
            numeros[0] = null;

            numeros[5] = "8";

            Console.WriteLine(" ");
            
            for (int i = 0; i < 6; i++)
            {
                Console.Write(numeros[i] + " ");
            }

            //lista
            List<int> lista = new List<int>();
            lista.Add(1); //0
            lista.Add(2); //1
            lista.Add(3); //2
            lista.Add(4); //3
            lista.Add(5); //4

            lista[1] = 6;

            lista[4] = 7;

            lista.Remove(1);

            lista.Add(8);

            Console.WriteLine(" ");

            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write(lista[i]);
            }
            
            lista.Add(9);

            for (int i = 0; i < lista.Count; i++)
            {
                lista[i] = lista[i] * 3;
            }

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] > 20)
                {
                
                  lista.RemoveAt(i);

                    i = i - 1;
                }
            }
            Console.WriteLine(" ");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write(lista[i]);
            }

            List<int> listaEnteros = new List<int>();
            listaEnteros.Add(2);
            listaEnteros.Add(6);
            listaEnteros.Add(19);
            listaEnteros.Add(34);
            listaEnteros.Add(65);
            listaEnteros.Add(12);
            listaEnteros.Add(42);
            listaEnteros.Add(33);
            listaEnteros.Add(40);
            listaEnteros.Add(15);

            int NumeroMax = 0;

            Console.WriteLine(" ");
            for (int i = 0; i < listaEnteros.Count; i++)
            {
                Console.Write(listaEnteros[i] + " ");
            }

            for(int i = 0; i < listaEnteros.Count; i++)
            {
                if(listaEnteros[i] > NumeroMax)
                {

                    NumeroMax = listaEnteros[i];

                }
            }
            Console.WriteLine(" ");
            Console.WriteLine(NumeroMax + " ");
        }
    }
}
