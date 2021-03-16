using System;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "OldsMobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";
            Console.WriteLine("{0} {1} {2} {3}", 
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);
            //decimal value = DetermineMarketValue(myCar);
            //Console.WriteLine("{0:c}", value);
            Console.WriteLine("{0:c}", myCar.DetermineMarketValue());

            Console.ReadLine();
        }
        private static decimal DeterminemarketValue(Car car)
        {
            decimal carValue = 100.0M;


            return carValue;
        }

    } 

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }  
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal carValue;

            if (Year > 1990)
                carValue = 10000;
            else
                carValue = 20000;

            return carValue;
        }

       
    }
}
