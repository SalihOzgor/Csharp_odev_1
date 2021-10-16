using System;

namespace Soru_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            */
            Console.WriteLine("Bir cümle yazınız: ");
            string cümle = Console.ReadLine();
            string[] cümleDizi = cümle.Split(" ");
            string cümleSon = string.Join("",cümleDizi);
            
            Console.WriteLine(cümleSon);
            Console.WriteLine("Yazdığınız cümledeki kelime sayısı {0}, harf sayısı {1}.",cümleDizi.Length,cümleSon.Length);
        }
    }
}
