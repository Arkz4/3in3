//show the main menu


using ClassLibrary1;

int userInput = 0;
List<Car> cars = new List<Car>();
List<Truck> trucks = new List<Truck>();
List<SUV> suvs = new List<SUV>();

while (userInput != 4)
{

    Console.WriteLine("Welcome to Jaden's Dealership");
    Console.WriteLine("");
    Console.WriteLine("--------------------------------------");
    Console.WriteLine("1. Add a New Car, Truck, or SUV");
    Console.WriteLine("2. List All Vehicles");
    Console.WriteLine("3. Remove all Vehicles");
    Console.WriteLine("4. Exit");
    string usersInput = "";
    try
    {
        usersInput = Console.ReadLine();
        userInput = int.Parse(usersInput);
    }
    catch (Exception ex)
    {
    }
    switch (userInput)
    {
        case 0:
            break;
        case 1:
            Console.WriteLine("1. Do you want to add a car ?");
            Console.WriteLine("2. Do you want to add a truck ?");
            Console.WriteLine("3. Do you want to add a suv ?");
            string type = Console.ReadLine();
            switch (type)
            {
                case "1":
                    Console.WriteLine("Add a new car");
                    string make, model, color;
                    int year;
                    Console.WriteLine("Enter the make");
                    make = Console.ReadLine();
                    Console.WriteLine("Enter the model");
                    model = Console.ReadLine();
                    Console.WriteLine("Enter the color");
                    color = Console.ReadLine();
                    Console.WriteLine("Enter the year");
                    year = int.Parse(Console.ReadLine());
                    Car newCar = new Car(make, model, year, color);
                    cars.Add(newCar);
                    break;
                case "2" :
                    Console.WriteLine("Add a new truck");
                    string tmake, tmodel, tcolor;
                    int tyear;
                    Console.WriteLine("Enter the make");
                    tmake = Console.ReadLine();
                    Console.WriteLine("Enter the model");
                    tmodel = Console.ReadLine();
                    Console.WriteLine("Enter the color");
                    tcolor = Console.ReadLine();
                    Console.WriteLine("Enter the year");
                    tyear = int.Parse(Console.ReadLine());
                    Truck newTruck = new Truck(tmake, tmodel, tyear, tcolor);
                    trucks.Add(newTruck);
                    break;

                case "3" :
                    Console.WriteLine("Add a new suv");
                    string smake, smodel, scolor;
                    int syear;
                    Console.WriteLine("Enter the make");
                    smake = Console.ReadLine();
                    Console.WriteLine("Enter the model");
                    smodel = Console.ReadLine();
                    Console.WriteLine("Enter the color");
                    scolor = Console.ReadLine();
                    Console.WriteLine("Enter the year");
                    syear = int.Parse(Console.ReadLine());
                    SUV newSUV = new SUV(smake, smodel, syear, scolor);
                    suvs.Add(newSUV);
              
                    break;
            }
            break;

        case 2:
            Console.WriteLine("List all Vehicles");
            foreach (var car in cars)
            {
                car.Displayinfo();
            }
            foreach (var truck in trucks)
            {
                truck.Displayinfo();
            }
            foreach (var suv in suvs)
            {
                suv.Displayinfo();
            }
            break;
        case 3:
            Console.WriteLine("Remove all Vehicles");
            cars.Clear();
            trucks.Clear();
            suvs.Clear();
            break;
    }
}