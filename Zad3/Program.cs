namespace Zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("vuvedi chislo ");
            int number = int.Parse(Console.ReadLine());

            
            int hundreds = number / 100;         
            int tens = (number / 10) % 10;        
            int edinici = number % 10;             

            // Извеждане на резултата
            Console.WriteLine($"stotici {hundreds}");
            Console.WriteLine($"desetici {tens}");
            Console.WriteLine($"edinici {edinici}");
        }


    }
    
}
