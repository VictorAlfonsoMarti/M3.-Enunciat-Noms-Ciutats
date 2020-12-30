using System;
using System.Collections.Generic;

namespace Exercici_Noms_Ciutats
{
    class Program
    {
        static void Main(string[] args)
        {
            //Milestone1();
            //Milestone2();
            Milestone3();
        }

        static void Milestone1()
        {
            // fase1 

            string var1;
            string var2;
            string var3;
            string var4;
            string var5;
            string var6;

            Console.WriteLine("Introdueix el nom de la ciutat 1");
            var1 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Introdueix el nom de la ciutat 2");
            var2 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Introdueix el nom de la ciutat 3");
            var3 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Introdueix el nom de la ciutat 4");
            var4 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Introdueix el nom de la ciutat 5");
            var5 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Introdueix el nom de la ciutat 6");
            var6 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\n Ciutats introduïdes: {0}, {1}, {2}, {3}, {4}, {5}.", var1, var2, var3, var4, var5, var6);

            // fase 2

            string[] arrayCiutats = new string[6] { var1, var2, var3, var4, var5, var6 };

            Array.Sort(arrayCiutats); // ordenem alfabeticament

            Console.WriteLine("\n Nom de les ciutats ordenades: {0}", string.Join(", ", arrayCiutats));

            // fase 3

            string[] arrayCambiat = new string[arrayCiutats.Length]; // creamos la nueva array

            Array.Copy(arrayCiutats, arrayCambiat, arrayCiutats.Length); // clonamos la array ciutats a la nueva array para no copiarla
            
            for (int x=0; x<arrayCambiat.Length; x++)
            {
                arrayCambiat[x] = arrayCambiat[x].Replace("a", "4"); //reccorrem l'arrai i canviem les a per 4
            }

            Console.WriteLine("\n Ciutats Modificades: {0}", string.Join(", ", arrayCambiat));
            Console.WriteLine("\n Ciutats Modificades: {0}", string.Join(", ", arrayCiutats));

            // fase 4

            char[] arrayVar1 = new char[var1.Length]; // creamos los nuevos arrays
            char[] arrayVar2 = new char[var2.Length];
            char[] arrayVar3 = new char[var3.Length];
            char[] arrayVar4 = new char[var4.Length];
            char[] arrayVar5 = new char[var5.Length];
            char[] arrayVar6 = new char[var6.Length];

            arrayVar1 = var1.ToCharArray(); //asignamos contenido de ciudades
            arrayVar2 = var2.ToCharArray();
            arrayVar3 = var3.ToCharArray();
            arrayVar4 = var4.ToCharArray();
            arrayVar5 = var5.ToCharArray();
            arrayVar6 = var6.ToCharArray();

            char[] arrayReverseVar1 = new char[var1.Length]; // creamos los arrays al reves
            char[] arrayReverseVar2 = new char[var2.Length];
            char[] arrayReverseVar3 = new char[var3.Length];
            char[] arrayReverseVar4 = new char[var4.Length];
            char[] arrayReverseVar5 = new char[var5.Length];
            char[] arrayReverseVar6 = new char[var6.Length];

            Array.Copy(arrayVar1, arrayReverseVar1, arrayVar1.Length); // copiamos el contenido respectivo
            Array.Copy(arrayVar2, arrayReverseVar2, arrayVar2.Length);
            Array.Copy(arrayVar3, arrayReverseVar3, arrayVar3.Length);
            Array.Copy(arrayVar4, arrayReverseVar4, arrayVar4.Length);
            Array.Copy(arrayVar5, arrayReverseVar5, arrayVar5.Length);
            Array.Copy(arrayVar6, arrayReverseVar6, arrayVar6.Length);

            Array.Reverse(arrayReverseVar1); // ponemos a los arrays dels reves
            Array.Reverse(arrayReverseVar2);
            Array.Reverse(arrayReverseVar3);
            Array.Reverse(arrayReverseVar4);
            Array.Reverse(arrayReverseVar5);
            Array.Reverse(arrayReverseVar6);

            Console.Write("\n Ex: {0} - {1}", string.Join("", arrayVar1), string.Join("", arrayReverseVar1)); // printamos
            Console.Write("\n Ex: {0} - {1}", string.Join("", arrayVar2), string.Join("", arrayReverseVar2));
            Console.Write("\n Ex: {0} - {1}", string.Join("", arrayVar3), string.Join("", arrayReverseVar3));
            Console.Write("\n Ex: {0} - {1}", string.Join("", arrayVar4), string.Join("", arrayReverseVar4));
            Console.Write("\n Ex: {0} - {1}", string.Join("", arrayVar5), string.Join("", arrayReverseVar5));
            Console.Write("\n Ex: {0} - {1}", string.Join("", arrayVar6), string.Join("", arrayReverseVar6));
        }

        public static void Milestone2()
        {
            int[,] notes = new int[3, 5]; // creem array multidimensional

            for (int x = 0; x < 3; x++) // recorrem array alumne
            {
                Console.WriteLine("Alumne {0}", x+1);  
                for (int y = 0; y < 5; y++) // recorrem array nota
                {
                    Console.WriteLine("Introdueix la nota de l'assignatura {0}, de 0 a 10. ", y+1); 
                    notes[x, y] = Convert.ToInt32(Console.ReadLine()); // asignem valor
                }
                Console.Clear();
            }

            Console.Clear();
            
            for (int x = 0; x < 3; x++)
            {
                int mediaAritmetica = 0; // creem variable volatil per guardar la mitjana
                for (int y = 0; y < 5; y++)  // recorrem notes 
                {
                    mediaAritmetica = mediaAritmetica + notes[x, y]; // sumem totes les notes i guardem
                }

                if ((mediaAritmetica/5) >=5) // comparem si major que 5
                {
                    Console.WriteLine("Alumne {0}: APROVAT", x);
                }
                else
                {
                    Console.WriteLine("Alumne {0}: SUSPÈS", x);
                }
            }
        }
        public static void Milestone3()
        {
            Console.WriteLine("FIBONACCI: Escriu un número: ");
            int objectiu = Convert.ToInt32(Console.ReadLine());

            int var1 = 0;
            int var2 = 1;
            int var3;

            for (int x = 0; x < objectiu; x++)
            {
                var3 = var1;
                var1 = var2;
                var2 = var1 + var3;
                Console.Write(" {0}", var1);
            }
        }
    }
}
