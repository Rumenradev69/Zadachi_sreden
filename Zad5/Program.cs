namespace Zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("vuvedi chislo");
            int number = int.Parse(Console.ReadLine());

            
            if (IsPrime(number))
            {
                Console.WriteLine($"{number} prosto");
            }
            else
            {
                Console.WriteLine($"{number} ne e prosto");
            }

            
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} chetno");
            }
            else
            {
                Console.WriteLine($"{number} nechetno");
            }
        }

        
        static bool IsPrime(int number)
        {
            if (number <= 1) return false; 
            for (int i = 2; i * i <= number; i++) 
            {
                if (number % i == 0)
                    return false; 
            }
            return true; 
        }
        // chata igra qko za toq bool
    }
}
