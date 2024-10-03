using System;

namespace uppgift2_3
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur många dagar tänker du köra bilen?");
            int dagar =int.Parse(Console.ReadLine());
            int dag1 = 300;
            int överst = 500;
            Console.WriteLine("hur många Kilometer tänker du köra?");
            int Km =int.Parse(Console.ReadLine());
            int sum= dag1 + dagar*överst +Km;
            Console.WriteLine(sum);

               







        }


    }
        

}