using System;

namespace Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            */
            Console.WriteLine("Girmek istediğiniz kelime sayısını (n) yazınız: ");
            int n = int.Parse(Console.ReadLine());

            string[] kelimeler = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. kelimeyi yazınız: ",i+1);
                kelimeler[i] = Console.ReadLine();
            }

            Array.Reverse(kelimeler);
            Console.WriteLine("Girişini yaptığınız kelimeler (sondan başa doğru) : ");

            foreach (string kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }
        }
    }
}
