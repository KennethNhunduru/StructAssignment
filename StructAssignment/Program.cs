using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    //Creating a struct called Number 
    public struct Number 
    {
        //Like a class, a struct can contain fields, properties, and methods
        //Giving the struct the property “Amount” and having it being of data type decimal.

        public decimal Amount { get; set; }

        static void Main(string[] args)
        {
            //Creating an object of data type Number in the Main() method, and assigning an amount to it.
            
            Number myNumber = new Number(); //Creating the object            
            myNumber.Amount = 3283.9M; //Assigning an amount to it.

            //Printing this amount to the console.
            Console.WriteLine("Amount is: " + myNumber);
            Console.ReadLine();

            //The output is "Amount is: StructAssignment.Number".
            //With Number being a struct, it is its own instance which is not related to myNumber 
            //since a struct CANNOT be inherited and neither can it inherit.
        }
    }
}
