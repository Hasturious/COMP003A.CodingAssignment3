﻿// Author: Jean Bryant Figueroa
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Budget management application demonstrating control flow.

namespace COMP003A.CodingAssignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LOOK AT PNG FROM CRUZ
            Console.Write("Enter your monthly income: ");
            int income = int.Parse(Console.ReadLine());
            int choice;

            //Declare our 5 different possible expenses and their cost
            string expenseName1 = "", expenseName2 = "", expenseName3 = "", expenseName4 = "", expenseName5 = "";
            int expensePrice1 = 0, expensePrice2 = 0, expensePrice3 = 0, expensePrice4 = 0, expensePrice5 = 0;

            /*
            I dont know how C# arrays work. My plan was to have a Name and Price array that could be called for hypothetical an infinite amount of expenses
            string[] expenseName = new string [5];
            int[] expensePrice = new int[5];
            */

            do
            {
                //print the list of options to the user and lets them choose between 4 int options (Johnathan's Idea)
                Console.Write("\n1. Add an Expense\n2. View Expenses and Budget\n3. Remove an Expence\n4. Exit\nEnter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the expense name: ");
                        //If the expense is blank we can overide it. The different varibles are combed 1 - 5 and are never shifted
                        //Basiclly imagine a rack with 5 shelves. First we try to put something on the bottom rack.
                        //if the bottom rack is full then we try the next, and the next. if we run out of shelves we cant store anything
                        //If a gap between say shelf 3 and shelf 5 is present, as we comb upwards we can fit our object into shelf 4
                        if (expenseName1 == "")
                        {
                            expenseName1 = Console.ReadLine();
                            Console.Write($"Enter the cost for {expenseName1}: ");
                            expensePrice1 = int.Parse(Console.ReadLine());
                        }
                        else if (expenseName2 == "")
                        {
                            expenseName2 = Console.ReadLine();
                            Console.Write($"Enter the cost for {expenseName2}: ");
                            expensePrice2 = int.Parse(Console.ReadLine());
                        }
                        else if (expenseName3 == "")
                        {
                            expenseName3 = Console.ReadLine();
                            Console.Write($"Enter the cost for {expenseName3}: ");
                            expensePrice3 = int.Parse(Console.ReadLine());
                        }
                        else if (expenseName4 == "")
                        {
                            expenseName4 = Console.ReadLine();
                            Console.Write($"Enter the cost for {expenseName4}: ");
                            expensePrice4 = int.Parse(Console.ReadLine());
                        }
                        else if (expenseName5 == "")
                        {
                            expenseName5 = Console.ReadLine();
                            Console.Write($"Enter the cost for {expenseName5}: ");
                            expensePrice5 = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("You have reached the maximum number of expenses.");
                        }
                        break;

                    case 2:
                        //Add up all the prices we collected in case 1 and make them into an easier to digest variable
                        int totalExpense = expensePrice1 + expensePrice2 + expensePrice3 + expensePrice4 + expensePrice5;
                        Console.WriteLine("\nExpenses:");
                        //If our expenseNames ARE NOT blank then we can log it in the list of expenses with its name and price
                        if (expenseName1 != "") Console.WriteLine($"- {expenseName1}: ${expensePrice1}");
                        if (expenseName2 != "") Console.WriteLine($"- {expenseName2}: ${expensePrice2}");
                        if (expenseName3 != "") Console.WriteLine($"- {expenseName3}: ${expensePrice3}");
                        if (expenseName4 != "") Console.WriteLine($"- {expenseName4}: ${expensePrice4}");
                        if (expenseName5 != "") Console.WriteLine($"- {expenseName5}: ${expensePrice5}");
                        //Then we grab the total expense variable from earlier
                        Console.WriteLine($"Total Expenses: {totalExpense}.00");
                        //And subtract it from our budget
                        Console.WriteLine($"Remaining Budget: {income - totalExpense}.00");
                        break;

                    case 3:
                        //First we declare that the removedExpense is string
                        string removedExpense = "";
                        Console.Write("Remove Expense: ");
                        removedExpense = Console.ReadLine();
                        //Then if the removed expense lines up with any of our expenses we strike the name and price from the record
                        //ofcourse if the expense does not exist the else statement should catch it
                        if (removedExpense == expenseName1)
                        {
                            expenseName1 = "";
                            expensePrice1 = 0;
                        }
                        else if (removedExpense == expenseName2)
                        {
                            expenseName2 = "";
                            expensePrice2 = 0;
                        }
                        else if (removedExpense == expenseName3)
                        {
                            expenseName3 = "";
                            expensePrice3 = 0;
                        }
                        else if (removedExpense == expenseName4)
                        {
                            expenseName4 = "";
                            expensePrice4 = 0;
                        }
                        else if (removedExpense == expenseName5)
                        {
                            expenseName5 = "";
                            expensePrice5 = 0;
                        }
                        else
                        {
                            Console.WriteLine("Not an expense");
                        }
                        break;
                    
                }
            } while (choice != 4);

            Console.WriteLine("Goodbye!");
            Console.ReadKey(); //On any keystroke the terminal closes

            //string menuResponse = Console.ReadLine();
            
            /*switch (menuResponse)
            {
                case "1":
                    Console.Write("Enter the expense name");
                    string expenseName = Console.ReadLine();
                    Console.Write("Enter the expense amount");
                    int expensePrice = int.Parse(Console.ReadLine());
                    break;
                case "2":
                    Console.WriteLine($"Expenses:\n- {expenseName} + {expensePrice}.00\nTotal Expenses: {expensePrice}.00\nRemaining Budget {income - expensePrice}");
                    break;
                case "3":
                    Console.Write("Remove Expense: ");
                    break;
            }*/



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
