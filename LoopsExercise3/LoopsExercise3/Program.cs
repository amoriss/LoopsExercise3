using System;

namespace LoopsExercise3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Checking Numbers with Loops!");
            Console.WriteLine("---------------------------");
            PrintNumbers();
            Console.WriteLine("---------------------------");
            CountByThree();

            int userNum1 = GetUserNumber();
            int userNum2 = GetUserNumber();
            IsEqual(userNum1, userNum2);
            IsEqual(5,5);
            IsEqual(10, 20);
            Console.WriteLine("---------------------------");

            IsEvenOrOdd(userNum1);
            IsEvenOrOdd(10);
            IsEvenOrOdd(11);
            Console.WriteLine("---------------------------");

            userNum1 = GetUserNumber();
            IsPositiveorNeg(userNum1);
            IsPositiveorNeg(-10);
            IsPositiveorNeg(10);
            Console.WriteLine("---------------------------");

            Vote();
            CanVote(18);
            CanVote(7);
            Console.WriteLine("---------------------------");

            int userNumber = GetUserNumber();
            InRange(userNumber);
            Console.WriteLine("---------------------------");
            int multiply = GetUserNumber();
            int num = GetUserNumber();
            MultiplicationTable(num, multiply);

            /*
             * 
             * Write a method that will print to the console all numbers 1000 through -1000.
                Write a method that will print to the console numbers 3 through 999 by 3 each time.
                Write a method to accept two integers as parameters and check whether they are equal or not.
                Write a method to check whether a given number is even or odd.
                Write a method to check whether a given number is positive or negative.
                Write a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... or the safer TryParse() for an extra challenge!!
*/

        }

        public static void PrintNumbers() //1000 through -1000
        {
            Console.WriteLine("Here are printed numbers 1000 through -1000 : ");
            for (int x = 1000; x > -1001; x--)
            {
                Console.WriteLine(x);
            }
             
        }

        public static void CountByThree() //3 through 999 by 3
        {
            Console.WriteLine("These are numbers 3-999 counted by 3");
            for (int x = 3; x <= 999; x += 3)
                Console.WriteLine(x);
        }

        public static void IsEqual(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine($"{x} is equal to {y} ");
            }
            else
            {
                Console.WriteLine($"{x} and {y} are not equal.");
            }
        }

        public static void IsEvenOrOdd(int x)
        {
            if ( x %2 == 0)
            {
                Console.WriteLine($"The number {x} is even.");
            }
            else
            {
                Console.WriteLine($"The number {x} is odd");
            }
        }

        public static void IsPositiveorNeg(int x)
        {
            if (x > 0)
            {
                Console.WriteLine($"Number {x} is positive");
            }
            else if (x < 0 )
            {
                Console.WriteLine($"Number {x} is negative");
            }
            else
            {
                Console.WriteLine("Invalid Number.");
            }
        }

        public static void CanVote(int x)
        {
            if (x >= 18)
            {
                Console.WriteLine($"At {x} years old, the person can vote.");
            }
            else
            {
                Console.WriteLine($"At {x} years old, the person cannot vote.");
            }
        }

        public static void Vote()
        {
            Console.WriteLine("How old is the person? Enter here: ");

            int age;

            var isNum = int.TryParse(Console.ReadLine(), out age);
            while (!isNum)
            {
                Console.WriteLine("Enter valid age");
                isNum = int.TryParse(Console.ReadLine(), out age);
            }

            if (age >= 18)
            {
                Console.WriteLine($"At {age} years old, the person can vote.");
            }
            else
            {
                Console.WriteLine($"At {age} years old, the person cannot vote.");
            }

            
      
        }

        public static void InRange(int userNumber)
        {
            if (userNumber >= -10 && userNumber <= 10)
            {
                Console.WriteLine($"{userNumber} is in range of -10 through 10");
            }
            else
            {
                Console.WriteLine($" {userNumber} is out of range of -10 through 10");
            }

        }

        public static void MultiplicationTable (int num, int multiply)
        {
            for (int i = 1; i <= multiply; i++)
            {
                int product = num * i;
                Console.WriteLine($" {num} x {i} = {product} ");
            }
        }

        public static int GetUserNumber()
        {
            Console.WriteLine("Enter a number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber; 
        }
    }
}
