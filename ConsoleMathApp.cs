using System;

namespace ConsoleMathApp
{
    class Program
    {
        static void Main()
        {
            //Ask user to enter a numnber
            Console.WriteLine("Enter a number: ");
            long number1 = Convert.ToInt64(Console.ReadLine());

            //Multiply the number by 50 and display the result
            long result1 = number1 * 50;
            Console.WriteLine("Number multiplied by 50: " + result1);

            //Ask the user to enter another number
            Console.WriteLine("Enter another number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            //Add 25 to number2 and display the result 
            int result2 = number2 + 25;
            Console.WriteLine("Number plus 25 : " + result2);

            //Ask the user to enter another number
            Console.WriteLine("Enter another Number: ");
            double number3 = Convert.ToDouble(Console.ReadLine());

            //Divide the number by 12.5 and display the result.
            double result3 = number3 / 12.5;
            Console.WriteLine("Number divided by 12.5: " + result3);

            //Ask the user to enter another number
            Console.WriteLine("Enter another Number: ");
            int number4 = Convert.ToInt32(Console.ReadLine());

            // check if the numvber is greater than 50
            bool result4 = number4 > 50;
            Console.WriteLine("Is the number greater than 50?" + result4);

            //ask the user to enter another number
            Console.WriteLine("Enter another number:");
            int number5 = Convert.ToInt32(Console.ReadLine());

            //divide hte nunber by 7 and display the remainder
            int result5 = number5 % 7;
            Console.WriteLine("The Remainder obtained after dividing the number by 7 is : " + result5);

            //Keep the console open for user to enter
            Console.ReadLine();
            

        }
    }
}