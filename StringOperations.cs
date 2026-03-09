using System;
using System.Text;//this is added for using string builder.
namespace StringOperations {
    class Program {
        static void Main(){
            //part 1 concatenate three strings

            //define three separate strings
            string firstName = "Jay";
            string lastName = "Krishnan";
            string realm = "conciousness";

            //concatenate three strings together
            string fullSentence =  firstName + "" + lastName + "lives in " + realm + ".";

            //Print the Concatenated result
            Console.WriteLine("Concatenated string: ");
            Console.WriteLine(fullSentence);

            //Part2 convert a string to uppercase

            //define a string
            string message = "Learning C# is Powerful";

            //convert the string to uppercase
            string UpperMessage = message.ToUpper();

            //display teh upper case result

            Console.WriteLine("\nUppercase string: ");
            Console.WriteLine(UpperMessage);

            //Part3 using string builder to build a paragraph


            //create a string builder object
            StringBuilder Paragraph = new StringBuilder();


            //Append messages one at a time
            Paragraph.Append(" Programming teaches logical thinking. ");
            Paragraph.Append("C# is a Powerful language used for crafting many applications.");
            Paragraph.Append("Regular practice makes the programing skills stroger like any other skill.");

            //display the completed  paragraph
            Console.WriteLine("\nParagraph created using StringBuilder: ");
            Console.WriteLine(Paragraph);

            //keep console open 
            Console.ReadLine();


        }
    }

}