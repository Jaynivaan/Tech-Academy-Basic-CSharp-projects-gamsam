using System;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main()
        {
            //print program title
            Console.WriteLine("Anonymous Income Comparison Program");

            //print person 1
            Console.WriteLine("Person-1");
            
            //Ask hourly rate for person 1
            Console.WriteLine("Whats your Hourly Rate ?");
            double Person1HourlyRate = Convert.ToDouble(Console.ReadLine());

            //Ask how many hours worked per week Person 1
            Console.WriteLine("How many Hours you worked per Week ?");
            double Person1Hours = Convert.ToDouble(Console.ReadLine());

            ///
            //print person 2
            Console.WriteLine("Person-2");
            
            //Ask hourly rate for person 2
            Console.WriteLine("Whats your Hourly Rate ?");
            double Person2HourlyRate = Convert.ToDouble(Console.ReadLine());

            //Ask how many hours worked per week Person 2
            Console.WriteLine("How many Hours you worked per Week ?");
            double Person2Hours = Convert.ToDouble(Console.ReadLine());

            //Calculate Annual Salary for Person 1
            double Person1Salary = Person1Hours * Person1HourlyRate * 52;

            //Calculate Annual Salary for Person 2
            double Person2Salary = Person2Hours * Person2HourlyRate * 52;

            //Print Salaries

            Console.WriteLine("Annual Salary of Person - 1 : ");
            Console.WriteLine(Person1Salary);

            Console.WriteLine("Annual Salary of Person - 2 :  ");
            Console.WriteLine(Person2Salary);

            //Comparisonboolean
            bool Person1MakesMore = Person1Salary > Person2Salary;

            //Print Comparison Result
            Console.WriteLine("Person 1 makes more money than Person  2.");
            Console.WriteLine(Person1MakesMore);

            //keep console open
            Console.ReadLine();

            



        }
    }
}