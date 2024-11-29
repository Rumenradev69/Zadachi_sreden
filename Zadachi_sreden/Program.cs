namespace Zadachi_sreden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("strana a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("strana b");
           int b = int.Parse(Console.ReadLine());
            Console.WriteLine("strana c");
            int c = int.Parse(Console.ReadLine());
            int p = (a + b + c);
            double P = p / 2.0;
            double s = Math.Sqrt(p*(p - a) * (p - b) * (p - c));
            Console.WriteLine($"perimeturat e {p} cm");
            Console.WriteLine($"liceto e {s}");

        }
    }
}
