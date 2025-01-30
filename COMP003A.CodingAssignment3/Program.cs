// Author: Jean Bryant Figueroa
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Budget management application demonstrating control flow.

namespace COMP003A.CodingAssignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your monthly income: ");
            int income = int.Parse(Console.ReadLine());

            Console.Write("\n1. Add an Expense\n2. View Expenses and Budget\n3. Remove an Expence\nExit\n");


            //in class lecture

            /*
            int wholeNumber;
            Console.Write("Enter any whole number: ");
            wholeNumber = int.Parse(Console.ReadLine());

            if (wholeNumber == 0)
                {
                Console.WriteLine("Zero");
                }
            else if (wholeNumber < 0)
            {
                Console.WriteLine("I dont do negative numbers");
            }
            else if (wholeNumber % 2 == 0)
                {
                Console.WriteLine("Even");
                }
            else
                {
                Console.WriteLine("Your number is odd");
                }
            */
            /*
            Console.Write("1-7: ");
            string weekDay = (Console.ReadLine());

            switch (weekDay.ToLower())
            {
                case "1":
                    Console.WriteLine("Monday");
                    break;
                case "2":
                    Console.WriteLine("Tuesday");
                    break;
                case "3":
                    Console.WriteLine("Wednesday");
                    break;
                case "4":
                    Console.WriteLine("Thursday");
                    break;
                case "5":
                    Console.WriteLine("Friday");
                    break;
                case "6":
                    //Console.WriteLine("Saturday");
                    break;
                case "7":
                    Console.WriteLine("Its the weekend");
                    break;
                case "0":
                    Console.WriteLine("Invalid Input")
                        break;
            */
            //for (initialization; condition; iteration)
            //{
            //Code to execute
            //}
            
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n\n");
            
            for (int i = 9; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            string output = ("#");
            for (int i = 0;i < 10; i++)
            {
                Console.WriteLine(output);
                output += "#"; //We repeat whats inside the bracket each loop. Each loop we add an additonal # to the output. output = # on first iteration. output = ### on third
            }
            */
        }
    }
}
