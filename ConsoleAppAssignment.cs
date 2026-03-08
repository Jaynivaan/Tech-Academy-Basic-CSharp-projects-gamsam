using System;

namespace ConsoleAppAssignment {
    class Program {
        static void Main(){
            //This loop will run atleast onces
            int number;
            do{
                //ask for number entry
                Console.WriteLine("Enter a number greater than 5: ");
                number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" YOU ENTERED : "+ number);

            }while(number<=5); //loop continues until this condition returns false

            //------while loop-------///
            //This loop counts numbers from 1 to 3
            int count = 1;

            while (count<= 3)
            {
                Console.WriteLine("Counting number: " + count);
                count++; //increase the count by 1

            }
            Console.WriteLine("Program Completed..Gam..");
            Console.ReadLine();
        }
    }
}