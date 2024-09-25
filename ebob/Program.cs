using System;

namespace ebob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            Console.WriteLine("Please enter the first number: ");
            sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            sayi2 = int.Parse(Console.ReadLine());

            // Eğer her iki sayı da 0 ise, EBOB tanımsızdır.
            if (sayi1 == 0 && sayi2 == 0)
            {
                Console.WriteLine("EBOB is undefined for both numbers being zero.");
            }
            else
            {
                int ebob = FindGCD(sayi1, sayi2);
                Console.WriteLine("Ebob({0},{1}) = {2}", sayi1, sayi2, ebob);
            }

            Console.ReadLine();
        }

        // Öklid algoritması kullanılarak EBOB hesaplama
        static int FindGCD(int a, int b)
        {
            // Negatif sayılar için mutlak değer alınır
            a = Math.Abs(a);
            b = Math.Abs(b);

            // Öklid algoritması (modulus kullanılarak)
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }
}
