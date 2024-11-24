using System;

namespace Boolean16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vvedite chetnoe dvuznachnoe chislo: ");
            var a = int.Parse(Console.ReadLine());
            bool result =(a>=10 && a<=99 && a % 2 ==0) ? true: false;
            Console.WriteLine(result);
        }
    }
}