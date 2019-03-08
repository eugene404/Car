using System;

namespace Car
{

    class Car
    {

        int carName;
        int wheels = 4;

        public Car()
        {
            
        }

                public double gearRatio(int finalDrive)
            {
                return finalDrive * 4.2 ;
            }

        static void Main(string[] args)
        {
            Car bmw = new Car();

            Console.WriteLine();
        }
    }
}
