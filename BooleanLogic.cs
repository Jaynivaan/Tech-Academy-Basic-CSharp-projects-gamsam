using System;

namespace BooleanLogic {
    class Program {
        static void Main()
        {
            //Ask users age
            Console.WriteLine("Whats your Age ?");
            int age = Convert.ToInt32(Console.ReadLine());

            //Ask if the user has had a DUI
            Console.WriteLine("If you ever had a DUI type true otherwise type false");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());


            //Ask how many speeding ticket the user has 
            Console.WriteLine("How many speeding ticket do you have sir?");
            int tickets = Convert.ToInt32(Console.ReadLine());


            //Apply insurance qualification rules
            bool qualified = (age > 15) && (!hasDUI) && (tickets <= 3);


            //print result
            Console.WriteLine("Qualified???");
            Console.WriteLine(qualified);

            //keep console open
            Console.ReadLine();
        }
    }
}