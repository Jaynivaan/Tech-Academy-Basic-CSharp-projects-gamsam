using System;

namespace PackageExpress {
    class Program{
        static void Main(){
            //welcome message
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.  ");

            //ask for Package weight
            Console.WriteLine("Please enter the Package Weight: ");
            //data typing and converting to decimal 
            decimal weight =  Convert.ToDecimal(Console.ReadLine());


            //if condition to check the weight 
            if(weight > 50) {
                //program end
                Console.WriteLine("Package too heavy to be shipped  via Package Express.  Have a good day. ");
                //leave the console open just forthe user to read 
                Console.ReadLine();
                return;


            }
            else
            {
                //Ask for dimensions ie width, height and length.
                Console.WriteLine("Please Enter the package width: ");
                decimal width = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Please Enter the Package Height: ");
                decimal height = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Please Enter the Package Length: ");
                decimal length = Convert.ToDecimal(Console.ReadLine());

                

                //Check the dimension size
                decimal dimensionTotal = width + height + length;

                if(dimensionTotal > 50) {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day. ");
                    Console.ReadLine();
                    return;

                }
                else
                {
                    //calculate shipping cost and come to a n appropriate quote.
                    decimal quote = ( width * height * length * weight ) / 100;

                    //Ternary operator applications
                    string message = (quote > 0)
                        ?"Your estimated total for shipping the package is : $" + quote.ToString("0.00")
                        :"Unable to compute the  quote. try again with something dimensional sir. Have a wonderful day sir!!!";
                    
                    Console.WriteLine(message);
                    Console.WriteLine("Thankyou sir for obtaining quote from PackageExpress .  Have a wonderful day sir!!!");
                    Console.ReadLine();
                }
            }                                                                                                                                                                               
        }
        
    }
}