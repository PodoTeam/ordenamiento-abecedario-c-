using System;
namespace EjercicioPractica
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] abc = new char[27] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string numero2;
            char[] numero;
            int cont1 = 0;
            Console.WriteLine("Ingrese una palabra");
            numero2 = Console.ReadLine().ToLower();
            numero = new char[numero2.Length];
            for (int i = 0; i < numero2.Length; i++)
            {
                numero[i] = Convert.ToChar(numero2.Substring(i, 1));
            }
            do
            {
                cont1++;
            } while (cont1 < numero.Length-1);
            Ordenamiento(numero, abc, cont1);
        }
        static void Ordenamiento(char[] numero, char[] abc, int cont1)
        {
            int gap = (numero.Length / 2);
            char aux;
            bool entrada = false, salida = false;
            char[] numero2 = new char[cont1];
            for (int b = 0; b < numero2.Length; b++)
            {
                numero2[b] = numero[b];
            }
            //Shell
            while (salida == false)
            {
                entrada = false;
                for (int i = 0; i < numero2.Length - gap; i++)
                {
                    if (numero2[i] > numero2[i + gap])
                    {
                        aux = numero2[i];
                        numero2[i] = numero2[i + gap];
                        numero2[i + gap] = aux;
                        entrada = true;
                    }
                }
                if (entrada == false && gap == 1)
                {
                    salida = true;
                }
                else if (entrada == false && gap > 1)
                {
                    gap--;
                }
            }
            for (int y = 0; y < numero2.Length; y++)
            {
                Console.Write(" {0}",numero2[y]);
            }
        }
    }
}