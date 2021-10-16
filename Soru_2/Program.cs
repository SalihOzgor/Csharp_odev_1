using System;

namespace Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            */
            Console.WriteLine("Girmek istediğiniz sayı adedini (n) yazınız: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Hedef sayıyı (m) giriniz: ");
            int m = int.Parse(Console.ReadLine());

            int[] sayılar = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz: ",i+1);
                sayılar[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Verdiğiniz sayılar içinde {0} sayısına eşit veya {1} sayısına tam bölünen sayılar şu şekilde: ",m,m);


            foreach (int sayı in sayılar)
            {
                if (sayı%m == 0)
                {
                    Console.WriteLine(sayı);
                }
            }
        }
    }
}
