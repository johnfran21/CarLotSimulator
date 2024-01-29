using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var future = new CarClass();


            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            CarLot instance = new CarLot();

            //instance.ListOfCars.Add(car1);
            //instance.ListOfCars.Add(car2);
            //instance.ListOfCars.Add(car3);

            CarClass car1 = new CarClass();
            car1.Make = "Toyota";
            car1.Model = "Prius";
            car1.Year = 2023;
            car1.EngineNoise = "quiet";
            car1.HonkNoise = "Beep";
            car1.IsDriveable = true;


            CarClass car2 = new CarClass()
            {
                Make = "Chevy",
                Model = "Tahoe",
                Year = 2024,
                EngineNoise = "loud",
                HonkNoise = "Bop",
                IsDriveable = true
            };




            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            CarClass car3 = new CarClass("Jeep", "Wrangler", 2022, "normal", "Boop Boop", true);
            {

            }

            instance.ListOfCars.Add(car1);
            instance.ListOfCars.Add(car2);
            instance.ListOfCars.Add(car3);

            foreach (CarClass item in instance.ListOfCars)
            {
                Console.WriteLine($"{item.Make}");
                Console.WriteLine($"{item.Model}");
                Console.WriteLine($"{item.Year}");
            }
        }
    }
}
