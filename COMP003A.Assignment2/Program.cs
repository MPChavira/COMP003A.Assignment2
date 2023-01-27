/* 
 * Author: Michael Perez Chavira
 * Course: COMP003A
 * Purpose: Assignment 2
 */

namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP-003A - Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor= ConsoleColor.White;

            Console.WriteLine("**********************************************");
            Console.WriteLine("String Section");
            Console.WriteLine("**********************************************");

            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your middle name:");
            string middleName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter age in 2023:");
            string inputAge = Console.ReadLine();
            int yearBorn = 2023 - Convert.ToInt32(inputAge);
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");

            Console.WriteLine("**********************************************");
            Console.WriteLine("Math Section");
            Console.WriteLine("**********************************************");



            Console.WriteLine("Enter an integer for integer1: 20 ");
            Console.WriteLine("Enter an integer for integer2: 4 ");



            var integer1 = Convert.ToInt32("20");
            var integer2 = Convert.ToInt32("4");



            Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");
            Console.WriteLine($"{integer1} - {integer2} = {integer1 - integer2}");
            Console.WriteLine($"{integer1} * {integer2} = {integer1 * integer2}");
            Console.WriteLine($"{integer1} / {integer2} = {integer1 / integer2}");
            Console.WriteLine($"{integer1} % {integer2} = {integer1 % integer2}");



            Console.WriteLine("**********************************************");
            Console.WriteLine("Circle Area & Circumference Calculator Section");
            Console.WriteLine("**********************************************");

            Console.WriteLine("Enter radius:5.8");
            Console.WriteLine("The area is 105.6296");
            Console.WriteLine("The circumference is 36.424");
            double radius = Convert.ToDouble(Console.ReadLine());
           
            double area = Math.PI * Math.Pow(radius, 2);
           
            double circumference = 2 * Math.PI * radius;















        }
    }
}