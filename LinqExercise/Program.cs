using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            var sumOfNum = numbers.Sum();
            Console.WriteLine(sumOfNum);
            Console.WriteLine();
            //TODO: Print the Average of numbers
            var averageOfNum = numbers.Average();
            Console.WriteLine(averageOfNum);
            //TODO: Order numbers in ascending order and print to the console
            var numSortAscending = numbers.OrderBy(number  => number);
            foreach (var number in numSortAscending)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            //TODO: Order numbers in descending order and print to the console
            var numSortDecending = numbers.OrderByDescending(number => number);
            foreach (var number in numSortDecending)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            //TODO: Print to the console only the numbers greater than 6
            var biggerThenSix = numbers.Where(number => number > 6);
            foreach (var number in biggerThenSix)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            var onlyPrintFour = numbers.Where(number => number > 5).OrderByDescending(number => number);
            foreach (var number in onlyPrintFour)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            var changeToAge = numbers.Select(n => n == 4 ? 18 : n).OrderByDescending(number => number);
            foreach (var number in changeToAge)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var isLetterInName = employees.Where(employe => employe.FirstName.StartsWith("C") || employe.FirstName.StartsWith("S")).OrderBy(employe => employe.FirstName);
            foreach (var employe in isLetterInName)
            {
                Console.WriteLine(employe.FullName);
            }
            Console.WriteLine();
            //var filteredStrings = strings.Where(s => lettersToCheck.Contains(s[0]));
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var Over26 = employees.Where(employe => employe.Age > 26);
            foreach (var employe in Over26)
            {
                Console.WriteLine(employe.FullName);
            }
            Console.WriteLine();
            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var averageOfAll = employees.Where(employe => employe.Age > 35).Where(employe => employe.YearsOfExperience <= 10).Average(employe => employe.YearsOfExperience);
            var sumOfAll = employees.Where(employe => employe.Age > 35).Where(employe => employe.YearsOfExperience <= 10).Sum(employe => employe.YearsOfExperience);
            Console.WriteLine(averageOfAll);
            Console.WriteLine(sumOfAll);
            Console.WriteLine();
            //TODO: Add an employee to the end of the list without using employees.Add()
            Employee newEmp = new Employee("Jorge", "Saldana", 18, 0);
            employees = employees.Concat(new[] { newEmp }).ToList();
            foreach (var employe in employees)
            {
                Console.WriteLine(employe.FirstName);
            }

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
