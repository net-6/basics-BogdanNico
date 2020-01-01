using System;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the number of exercise to run: ");
            string exercise = Console.ReadLine();

            // 1.Write a method that reads from the console three numbers of type int and prints their sum.
            if (exercise == "1")
            {
                int a, b, c;
                Console.WriteLine("Enter three integer numbers:");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
                SumOfThree s = new SumOfThree();
                Console.WriteLine("The sum of the three numbers is {0}", s.Sum(a, b, c));
            }

            // 2.Write a method that reads five numbers from the console and prints the greatest of them.
            if (exercise == "2")
            {
                int a, b, c, d, e;
                Console.WriteLine("Enter five integer numbers:");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
                d = int.Parse(Console.ReadLine());
                e = int.Parse(Console.ReadLine());
                GreatestOfFive g = new GreatestOfFive();
                Console.WriteLine("The greatest number is {0}", g.Max(a, b, c, d, e)); 
            }

            // 3.Write a method that reads from the console the radius "r" of a circle and prints its perimeter and area.
            if (exercise == "3")
            {
                double radius;
                double pi = Math.PI;
                Console.WriteLine("Enter the radius of the circle:");
                radius = double.Parse(Console.ReadLine());
                
                CirclePerimeterAndArea p = new CirclePerimeterAndArea();
                Console.WriteLine("The circle perimeter is {0:F2}", p.CirclePerimeter(radius, pi));
                
                CirclePerimeterAndArea a = new CirclePerimeterAndArea();
                Console.WriteLine("The circle area is {0:F2}", a.CircleArea(radius, pi));                
            }

            /* 4.Write a method that reads from the console two integer numbers (int) and prints
              how many numbers between them exist that are divisible with 5. such that the remainder of their division by 5 is 0. */
            if (exercise == "4")
            {
                int a, b, min, max, counter=0;
                Console.WriteLine("Enter two integer numbers:");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                if (a>b) { max = a; min = b ; } else { max = b; min = a; }
               
                NumbersBetween n = new NumbersBetween();
                Console.WriteLine("There are {0} numbers divisible by 5", n.HowManyNumbersBetween(min, max, counter));
            }

            /* 5.Write a method that reads two numbers from the console and prints the greater of them. 
             Solve the problem without using conditional statements and with conditional statements. */
            if (exercise == "5")
            {
                int a, b;
                Console.WriteLine("Enter two integer numbers:");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());

                GreatestOfTwo c = new GreatestOfTwo();
                Console.WriteLine("The greatest of two, without using conditional is {0}", c.GreatestWithoutConditional(a, b));

                GreatestOfTwo w = new GreatestOfTwo();
                Console.WriteLine("The greatest of two, using conditional is {0}", w.GreatestWithConditional(a, b));
            }
           
            /* 6.Write a method that reads five integer numbers and prints their sum. If an invalid number is entered
             the method should prompt the user to enter another number (only once) */
             if (exercise == "6")
            {
                int sum=0, value;
                Console.WriteLine("Insert five integer numbers: ");
                for (int i = 1; i <= 5; i = i + 1)
                {
                Console.WriteLine("Insert integer {0} now: ", i);
                   
                    while (!int.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("Not a valid integer. Insert a valid integer {0}", i);
                    }
                    sum = sum + value;
                }
                Console.WriteLine("The sum of the five numbers is {0}", sum);
            }

            // 7.Write a method that prints on the console the numbers from 1 to N. The number N should be read from the standard input.
            if (exercise == "7")
            {
                int n;
                Console.WriteLine("Insert number n:");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("The numbers from 1 to {0} are:", n);
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }

            /* 8.Write a method that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously.
            The number N should be read from the standard input. */
            if (exercise == "8")
            {
                int n;
                Console.WriteLine("Insert number n:");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("The numbers from 1 to {0}, not divisible by 3 and 7, are:", n);
                for (int i = 1; i <= n; i++)
                {
                    if ((i % 3 != 0) && (i % 7 != 0))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            
            // 9.Write a method that reads from the console a series of 5 integers and prints the smallest and largest of them.
            if (exercise == "9")
            {
                int a, b, c, d, e;
                Console.WriteLine("Enter five integer numbers:");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
                d = int.Parse(Console.ReadLine());
                e = int.Parse(Console.ReadLine());

                SmallestOfFive s = new SmallestOfFive();
                Console.WriteLine("The smallest number is {0}", s.Min(a, b, c, d, e));

                GreatestOfFive g = new GreatestOfFive();
                Console.WriteLine("The greatest number is {0}", g.Max(a, b, c, d, e));
            }

            /* 10.	Write method that outputs a triangle made of stars with variable size, depending on an input parameter.
             Look at the examples to get an idea. The input comes as a string number, which needs to be parsed to a number.
             The output is a series of lines printed on the console, forming a triangle of variable size. */
             if (exercise == "10")
            {
                int n;
                Console.WriteLine("Insert number n:");
                n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            }

            // 11.Write a method that converts a given number from decimal to binary notation (numeral system).
            if (exercise == "11")
            {
                int n,i;
                int[] a = new int[30];
                Console.WriteLine("Insert number in decimal:");
                n = int.Parse(Console.ReadLine());
                for (i=0; n>0; i++)
                {
                    a[i] = n % 2;
                    n = n / 2;
                }
                Console.WriteLine("The number in binary is: ");
                for (i=i-1; i>=0; i--)
                {
                    Console.WriteLine(a[i]);
                }   
            }

            // 12.Write a method that by a given integer N prints the numbers from 1 to N in random order
            if (exercise == "12")
            {
                int n;
                Console.WriteLine("Insert number n:");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("The numbers from 1 to {0} are:", n);

                Random rand = new Random();
                for (int i = 1; i <= n; i++)
                {   
                    Console.WriteLine(rand.Next(n));
                }
            }

            /* 13.A method which iterates the integers from 1 to 50 For multiples of three print "Fizz" instead of the number and for 
             the multiples of five print "Buzz". For numbers which are multiples of both three and five print "FizzBuzz". */
            if (exercise == "13")
            {
                
                for (int i = 1; i <= 50; i++)
                {
                    if ((i % 3 == 0) && (i % 5 == 0))
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    if ((i % 3 == 0) && (i % 5 != 0))
                    {
                        Console.WriteLine("Fizz");
                    }
                    if ((i % 5 == 0) && (i % 3 != 0))
                    {
                        Console.WriteLine("Buzz");
                    }
                    if ((i % 3 != 0) && (i % 5 != 0))
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            /* 14.A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and
             phone number. Write a program that reads information about the company and its manager and then prints it on the console. */
            if (exercise == "14")
            {
                Console.Write("Insert company's name: ");
                string companyName = Console.ReadLine();

                Console.Write("Insert company's address: ");
                string companyAdress = Console.ReadLine();

                Console.Write("Insert company's phone number: ");
                string companyPhoneNumber = Console.ReadLine();

                Console.Write("Insert company's fax number: ");
                string companyFaxNumber = Console.ReadLine();

                Console.Write("Insert company's web site: ");
                string companyWebSite = Console.ReadLine();

                Console.Write("Insert company's manager name: ");
                string managerName = Console.ReadLine();

                Console.Write("Insert company's manager surname: ");
                string managerSurame = Console.ReadLine();

                Console.Write("Insert company's manager phone: ");
                string managerPhone = Console.ReadLine();

                Console.WriteLine("{0}", companyName);
                Console.WriteLine("Address: {0}", companyAdress);
                Console.WriteLine("Phone number: {0}", companyPhoneNumber);
                Console.WriteLine("Fax number: {0}", companyFaxNumber);
                Console.WriteLine("Web site: {0}", companyWebSite);
                Console.WriteLine("Manager: {0}" + " " + "{1}" + " " + "Phone number: {2} ", managerName, managerSurame, managerPhone);
            }
        }
    }
}
