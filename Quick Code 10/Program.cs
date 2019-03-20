using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Code_10
{
    class Program
    {
        public enum Fruit
        {
            Rasberry,
            Strawberry,
            Blueberry,
            Blackberry,
            Apple,
            Orange,

        }


        static void Main(string[] args)
        {
            //
            // Variables
            //
            string userResponse;
            //
            // Declare Arrays
            //

            Fruit[] favoriteFruit = new Fruit[3];


                Console.WriteLine("What are you three favorite kinds of fruits?");

            for (int index = 0; index < 3; index++)
            {
                Console.WriteLine($"Fruit {index +1}: ");
                userResponse = Console.ReadLine();
                Enum.TryParse(userResponse, out favoriteFruit[index]);

            }
            Console.WriteLine();

            foreach (Fruit fruit in favoriteFruit)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }
    }
}
