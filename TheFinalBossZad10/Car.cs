using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBossZad10
{
    public class Car
    {

        private string make;
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private string registrationNumber;
        public string RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }

        private int yearOfManufacture;
        public int YearOfManufacture
        {
            get { return yearOfManufacture; }
            set { yearOfManufacture = value; }
        }
        public Car(string make, string model, string registrationNumber, int yearOfManufacture)
        {
            Make = make;
            Model = model;
            RegistrationNumber = registrationNumber;
            YearOfManufacture = yearOfManufacture;
        }
        public void Drive()
        {
            Console.WriteLine($"{Make} {Model}: brum brum ");
        }
        public void Eco()
        {
            if (YearOfManufacture > 2000)
            {
                Console.WriteLine("eco");
            }
            else
            {
                Console.WriteLine("ne e eco");
            }
        }
        public void Info()
        {
            Console.WriteLine($"Marka: {Make}, Model: {Model}, Reg. nomer: {RegistrationNumber}, Godina na proizvodstvo: {YearOfManufacture}");
        }




    }



}
