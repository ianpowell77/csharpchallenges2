using System;
using System.Collections.Generic;

namespace Week18
{
    class Program
    {
        static void Main(string[] args)
        {

            checkContinue(1);

            //Challenge 1
            try
            {
                Console.WriteLine("Please enter a number you want to be divided.");
                int num1 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Please enter a number you want to divide {0} by.", num1);
                int num2 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("The quotient is {0}", Divide(num1, num2));
            } catch (Exception)
            {
                Console.WriteLine("Please input a valid number");
            }

            checkContinue(2);

            //Challenge 2 ----- Class is in Challenge2.cs
            var car1 = new Car();
            car1.model = "Subaru BRZ";
            var car2 = new Car();
            car2.model = "Nissan Altima";
            var car3 = new Car();
            car3.model = "Ford Bicycle";
            Console.WriteLine("Car 1 is a {0} {1} with {2} tires.", car1.year, car1.model, car1.numberOfTires);
            Console.WriteLine("Car 2 is a {0} {1} with {2} tires.", car2.year, car2.model, car2.numberOfTires);
            Console.WriteLine("Car 3 is a {0} {1} with {2} tires.", car3.year, car3.model, car3.numberOfTires);

			checkContinue(3);

            //Challenge 3
            Dictionary<string, byte> roadToHire = new Dictionary<string, byte>();
            roadToHire.Add("Malik", 21);
            roadToHire.Add("Ivan", 19);
            roadToHire.Add("Angel", 19);
            roadToHire.Add("Mickey", 19);
            roadToHire.Add("Markus", 19);
            roadToHire.Add("Chris", 21);
            roadToHire.Add("Teia", 23);
            roadToHire.Add("Britanny", 23);
            roadToHire.Add("Ian", 20);
            roadToHire.Add("Lesly", 18);
            roadToHire.Add("Juan", 18);
            roadToHire.Add("Victoria", 22);
            roadToHire.Add("Hunter", 18);
            roadToHire.Add("Miguel", 22);
            roadToHire.Add("John", 36);

            Console.WriteLine("There are {0} students in road2hire, but we're only supposed to have 14. Who is the random student?", roadToHire.Count);
            roadToHire.Remove("John");
            Console.WriteLine("We found a John that wasn't supposed to be there, and we removed him. We now only have {0} students", roadToHire.Count);
            foreach (KeyValuePair<string, byte> pair in roadToHire)
            {
                if(pair.Key == "Ian")
                {
                    Console.WriteLine("I found myself in the dictionary, my name is {0} and I'm {1} years old.", pair.Key, pair.Value);
                }
            }

            checkContinue(4);

            //Challenge 4
            var vehicle1 = new Vehicle("Sedan", 4, "2014", "Volkswagon Jetta");
            var vehicle2 = new Vehicle("Coupe", 4, "2012", "Nissan 350z");
            var vehicle3 = new Vehicle("Bicycle", 2, "2018", "Ford PedalFaster");
            Console.WriteLine("Car 1 is a {0} {1} with {2} tires. It's also a {3}.", vehicle1.year, vehicle1.model, vehicle1.numberOfTires, vehicle1.type);
			Console.WriteLine("Car 2 is a {0} {1} with {2} tires. It's also a {3}.", vehicle2.year, vehicle2.model, vehicle2.numberOfTires, vehicle2.type);
			Console.WriteLine("Car 3 is a {0} {1} with {2} tires. It's also a {3}.", vehicle3.year, vehicle3.model, vehicle3.numberOfTires, vehicle3.type);
        }

		public static int Divide(int num1, int num2)
		{
            int num3 = num1 / num2;
            return num3;
		}

        public static void checkContinue(byte count){
            Console.WriteLine("We're moving onto challenge {0}, are you ready? Y/N", count);
			if (Console.ReadLine().ToUpper() != "Y")
			{
				Console.WriteLine("Thank you, Goodbye.");
				Environment.Exit(0);
			}
            Console.Clear();
        }
    }
}
