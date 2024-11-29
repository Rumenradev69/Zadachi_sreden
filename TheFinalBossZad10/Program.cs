namespace TheFinalBossZad10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Car> carsInRace = new List<Car>();

           
            Car car1 = new Car("MMerc", "E63s", "CA6666AB", 2018);
            carsInRace.Add(car1);

            
            Car car2 = new Car("BMW", "M3", "CA9999BC", 2020);
            carsInRace.Add(car2);

            
            foreach (Car car in carsInRace)
            {
                car.Drive();
                car.Eco();
                car.Info();
            }

            
            Console.WriteLine($"broi uchastnici {carsInRace}");
        }
    }
}
