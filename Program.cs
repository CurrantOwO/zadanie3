using System;
using System.Text;

namespace zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a = { -9, 3, 2, 3, 6, 46, -5, 6, 7}; //массив от которого пляшем

            //номер 1

            int min = 999, d = 0; ;
            for(int i = 0; i < a.Length; i++)
            {
                if (Math.Abs(a[i]) < min) {
                    min = Math.Abs(a[i]);
                    d = i;
                }
            }
            Console.WriteLine("Наименьшее число в массиве находится под номером " + d);

            //номер 2
            int[] ba = new int[a.Length];
            for (int i = 0;  i < a.Length; i++) {
                ba[i] = a[i];
            }
            for(int i = 0; i < a.Length - 1; i++)
{
                for(int l = i + 1; l < a.Length - 1; l++) {
                    int b = 0;
                    if(a[i] == a[l]) { b++; }
                    if(b > 0) { ba[i] = 0; ba[l] = 0; }
                }
            }
            for (int i = 0; i < ba.Length; i++) {
                if (ba[i] != 0) { Console.Write(ba[i] + "\t"); }
            }
            Console.WriteLine("\n");

            //номер 3
            Random ran = new Random();
            int za = 0, ka = 0;
            for(int i = 0; i < ba.Length; i++) { 
                ba[i] = ran.Next(-100, 100);
                Console.Write(ba[i] + "\t");
                if(ba[i] > 0) { za++; }
            }
            Console.WriteLine();
            int[] az = new int[za];
            for (int i = 0; i < ba.Length; i++) {
                if (ba[i] > 0) {
                    az[ka] = ba[i];
                    ka++;
                }
            }
            for(int i = 0; i < az.Length; i++) { Console.Write(az[i] + "\t"); }
        }
    }
}
