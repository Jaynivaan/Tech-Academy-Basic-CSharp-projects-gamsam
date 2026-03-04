using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            //print school name
            Console.WriteLine("Academy of Learning Career College");

            //print report title
            Console.WriteLine("Student Daily Report");

            //Ask student name
            Console.WriteLine("What is your Name ?");
            //readline give input oppurtunity for theuser.
            string studentName = Console.ReadLine();

            //Ask course name
            Console.WriteLine("What course are you on ?");
            string studentCourse = Console.ReadLine();

            //Ask Page Number
            Console.WriteLine("What Page Number ?");
            int pageNumber = Convert.ToInt32(Console.ReadLine()) ;

            // Ask if help is needed
            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            //to bool casting from string type
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            //Ask about positive Experiences
            Console.WriteLine("Were there any positive experiences you 'd like to share? Please give specifics..");
            string positiveExperience = Console.ReadLine();

            //Ask for additional feed back
            Console.WriteLine("Is there any other feedback you'd like to provide ? Please give specifics..");
            string additionalFeedback = Console.ReadLine();

            //Ask about the numbner of hours studied..
            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());

            //final message
            Console.WriteLine("Thankyou for your answers.  An Instructor will respond shortly.  Have a great day!"); 
            Console.ReadLine();



        }
    }
}