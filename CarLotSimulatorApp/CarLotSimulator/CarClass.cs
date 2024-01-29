using System;
namespace CarLotSimulator
{
    internal class CarClass
    {
        public CarClass()
        {

        }
        public CarClass(string make, string model, int year, string engineNoise, string honkNoise, bool isDriveable)
        {
            Make = make;
            Model = model;
            Year = year;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }

            public string Make { get; set; }

            public string Model { get; set; }

            public int Year { get; set; }

            public string EngineNoise { get; set; }

            public string HonkNoise { get; set; }

            public bool IsDriveable { get; set; }


            public void MakeEngineNoise(string noise)
            {
                Console.WriteLine("$ The {make}'s engine noise goes {engineNoise}");
            }
            public void MakeHonkNoise(string noise)
            {
                Console.WriteLine("$ The {make}'s honk noise goes {engineNoise}");
            }
     
    }
    
    
}

//Create a seperate class file called Car - Done
//Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable - Done
//Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
//The methods should take one string parameter: the respective noise property