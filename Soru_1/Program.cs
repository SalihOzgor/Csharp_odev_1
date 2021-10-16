using System;

namespace Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            */
            Console.WriteLine("Girmek istediğiniz sayı adedini(n) yazınız: ");
            int n = int.Parse(Console.ReadLine());

            int [] sayılar = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz: ",i+1);
                sayılar[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Çift sayılar şunlar: ");
            foreach (int sayı in sayılar)
            {
                if (sayı%2==0)
                {
                    Console.WriteLine(sayı);
                }
            }
        }
    }
}
