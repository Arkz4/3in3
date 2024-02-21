using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class Truck
    {
        // attributes of truck
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }
        public string VIN { get; set; }


        //Constructor
        public Truck(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            Mileage = 0;

        }
        //Methods
        public void Drive(int miles)
        {
            if (miles > 0)
            {
                Mileage += miles;
            }
        }

        public void Displayinfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}, Mileage: {Mileage}");
        }

        public int getMileage()
        {
            return Mileage;
        }
    }
}