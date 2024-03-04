using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan bir sınır değer girilmesi istenir.
            //Girilen sayıya kadar olan fibonacci sayıları yazdıran c# kodu yazdıran
            //Fibonacci sayı ilk iki elemanı 1 olan, kendinden önceki sayıyla toplanarak devam eden sayı dizisi.
            //Fibonacci Sayıları :: {1,1,2,3,5,8,13,21,34,55,89,144,233,377....}
            int sinir;
            while (true) // Kullanıcı geçerli bir giriş yapana kadar döngüyü çalıştırır.
            {
                Console.WriteLine("Değer girin: ");  // Kullanıcının girdisini alır ve dönüşümü başarılıysa sınır değişkenine atanır.

                if (int.TryParse(Console.ReadLine(), out sinir))//Hatalı bir giriş olduğunda programın sonlandırılmaması için int.TryParse() fonksiyonu kullanıldı.
                {
                    break; // Geçerli bir giriş yapıldığında döngüden çıkar.
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen bir tam sayı girin."); //Geçersiz bir giriş olduğunda döngüyü devam ettirir ve kullanıcıdan yeni bir giriş bekler.
                }
            }

            int a = 0, b = 1, c;

            Console.WriteLine("Fibonacci Sayıları:");

            if (sinir >= 1)
            {
                Console.Write(a + " "); //Kullanıcı en az bir fibonacci sayısı isterse ilk sayı 0 ile başlar.
            }
            if (sinir >= 2)
            {
                Console.Write(b + " "); //Kullanıcı en az iki fibonaccii sayısı isterse ikinci sayı olan 1 yazılır.
            }

            for (int i = 2; i < sinir; i++)  //Sayılar hesaplanır ve yazdırılır.
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
            Console.ReadLine(); // Kullanıcının uygulamadan çıkmasını engellendi.




            // int sinir = Convert.ToInt32(Console.ReadLine()); Kullanıcı başka bir değer girdiği zaman uygulama kapandı(?)
            //int a = 0, b = 1, c;

            //Console.WriteLine("Fibonacci Sayıları:"); 

            //if (sinir >= 1)
            //{
            //    Console.Write(a + " "); // İlk Fibonacci sayısı yazdırılır.
            //}
            //if (sinir >= 2)
            //{
            //    Console.Write(b + " "); // İkinci Fibonacci sayısı yazdırılır.
            //}

            //for (int i = 2; i < sinir; i++) // Fibonacci sayıları hesaplanır ve yazdırılır.
            //{
            //    c = a + b;
            //    Console.Write(c + " ");
            //    a = b;
            //    b = c;
            //    Console.ReadLine(); 
        }
    }
}
