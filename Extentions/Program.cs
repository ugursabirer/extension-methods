using System;

namespace Extentions
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi = 3;

            //string str = "test";

            //Console.WriteLine(sayi.Faktoriyel(str));

            //Person person = new Person(1, "Uğur", "Sabırer");

            //Console.WriteLine(person.FullName());

            string telefon = "543 321 21 54";

            Console.WriteLine(telefon.ToTelefonFormat());

            telefon = "+90 (543) 321 21 54";

            Console.WriteLine(telefon.ToTelefonFormat());
        }
    }
}
