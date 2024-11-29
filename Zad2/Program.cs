using System.Security.Cryptography;

namespace Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vavedi r");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("vuvedi h");
            double h = double.Parse(Console.ReadLine());
            
            double PI = 3.14;
            double s =2*PI*r*(r+h);
            double v = PI * r * r * h;
            Console.WriteLine($"obema e {v}");
            Console.WriteLine($"liceto e {s}");
        }
    }
}
