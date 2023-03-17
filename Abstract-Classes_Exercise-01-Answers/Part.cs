using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Exercise_01_Answers
{
    // TODO:  Create an abstract class called Part 
    public abstract class Part
    {
        // TODO:  Inside of the abstract Part class, Create 3 abstract properties called ID, Name, and Price 
        public abstract int ID { get; set; }
        public abstract string Name { get; set; }
        public abstract decimal Price { get; set; }

        // TODO:  Inside of the abstract Part class, Create 1 abstract void method called PrintPartInfo()
        public abstract void PrintPartInfo();

        // TODO:  Inside of the abstract Part class, Create 1 private static field of type ulong called _partCount;
        private static ulong _partCount;
        
        // TODO:  Inside of the abstract Part class, Create 1 parameterized constructor foreach of the 4 properties and also increment the _partCount field
        public Part(int iD, string name, decimal price)
        {
            ID = iD;
            Name = name;
            Price = price;
            _partCount++;

        }

        // BONUS: Inside of the abstract Part class, Create 1 static void method called PrintTotalPartCount() 
        public static void PrintTotalPartCount() 
        {
            Console.WriteLine($"TOTAL CREATED PARTS: {_partCount}");
        }
    }
}
