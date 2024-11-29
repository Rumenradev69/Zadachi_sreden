namespace Zad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;        
            int negativeCount = 0; 
            int number;

            
            number = int.Parse(Console.ReadLine());


            while (true)
            {
                number = int.Parse(Console.ReadLine());
                if (number == 0) break;

                count++; 

                if (number < 0) 
                   negativeCount++;
            }

            
            Console.WriteLine($"broi {count}");         
            Console.WriteLine($"otricatelni broi {negativeCount}"); 
        }
    }
}
