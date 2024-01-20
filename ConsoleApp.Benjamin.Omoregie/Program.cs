using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Benjamin Omoregie
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2024-01-19
 * Updated: 2019-03-03
 */

namespace Business.Benjamin.Omoregie
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            // 1. Declare a variable of Quote type.
            Quote quote;

            // 2. Define the variable above to a new Quote instance with a sale price
            //    and tax rate of your choosing.
             quote = new Quote(5000, 0.05m);

            // 3. Print the state of the Quote object using accessor methods. 
            //    Format of the output is: 
            //    field: value
            Console.WriteLine($"Sale Price:{quote.SalePrice}");
            Console.WriteLine($"Tax Rate: {quote.TaxRate}");

            // 4. Print the Quote instance created in a previous step.
            Console.WriteLine(quote);

            // 5. Declare and define a new Quote object with the default state.
            Quote quote2 = new Quote();

            // 6. Update the state of the second Quote object with a sale price 
            //    between $10,000 - $15,000 and a tax rate between 4.01% and 4.99% 
            //    (inclusive).
            quote2.SalePrice = 10000;
            quote2.TaxRate = 0.0401m;

            // 7. Declare a variable of List type that can store Vehicle objects.
            List<Vehicle> vehicle;

            // 8. Define the variable from the previous step to an empty List object.
            vehicle = new List<Vehicle>();

            // 9. Populate the List with 3 Vehicle objects. Each Vehicle object must 
            //    have unique state.
            vehicle.Add(new Vehicle(2024, "Modely", "Manufacturer1", PaintColor.Red, 80000));
            vehicle.Add(new Vehicle(2023, "ModelZ", "Manufacturer2", PaintColor.Blue, 60000));
            vehicle.Add(new Vehicle(2021, "ModelS", "Manufacturer3", PaintColor.Green, 50000));

            // 10. Print out the number of objects in the List, using the List object
            //     reference.
            Console.WriteLine($"Number of vehicle:{vehicle.Count}");

            // 11. Print out the Vehicle objects from the List.
            foreach(var car  in vehicle)
            {
                Console.WriteLine(car);
            }
            Console.ReadLine();
        }
    }
}
