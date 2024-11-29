namespace Zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedi chislo 1");
            int chislo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("vuvedi chislo2");
            int chislo2 = int.Parse(Console.ReadLine());
            Console.WriteLine("vuvedi chislo3");
            int chislo3 = int.Parse(Console.ReadLine());
            if (chislo1 > chislo2)
            {
                int x = chislo1;
                chislo1 = chislo2;
                chislo2 = x;

            }
            if (chislo1 > chislo3)
            {
                int x = chislo1;
                chislo1 = chislo3;
                chislo3 = x;

            }
            if (chislo2 > chislo3)
            {
                int x = chislo2;
                chislo2 = chislo3;
                chislo3 = x;

            }
            Console.WriteLine($"a= {chislo1} b= {chislo2} c = {chislo3}");



        }
    }
}
