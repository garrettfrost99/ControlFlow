using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    public class ExerciseOne
    {
        public void exerciseOne()
        {
            int count = 0;

            for(int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }

            Console.WriteLine(count);
        }
    }
    public class ExerciseTwo
    {
        public void exerciseTwo()
        {
            string input = "";
            bool keepGoing = true;
            int total = 0;

            while (keepGoing == true)
            {
                Console.WriteLine("Please neter a number or OK to exit: ");
                input = Console.ReadLine();

                if (input.ToUpper() == "OK")
                    keepGoing = false;
                else
                    total += Convert.ToInt32(input);
            }

            Console.WriteLine(total);
        }
    }
    public class ExerciseThree
    {
        public void exerciseThree()
        {
            int factorial = 0, total = 0;
            Console.WriteLine("Enter a number to see the factorial: ");
            factorial = Convert.ToInt32(Console.ReadLine());

            for(int i = factorial; i > 0; i--)
            {
                if (i == factorial)
                    total += factorial;
                else
                    total *= i;
            }

            Console.WriteLine(factorial + "!= " + total);
        }
    }
    public class ExerciseFour
    {
        public void exerciseFour()
        {
            Random rand = new Random();
            bool guessed = false;
            int random = rand.Next(1,10);
            int count = 0, numberGuessed = 0;

            Console.WriteLine(random);

            while(guessed != true && count < 4)
            {
                Console.WriteLine("Enter a guess: ");
                numberGuessed = Convert.ToInt32(Console.ReadLine());

                if (numberGuessed == random)
                    guessed = true;
                else
                    count++;
            }

            if (guessed)
                Console.WriteLine("You won.");
            else
                Console.WriteLine("You lost.");
        }
    }
    public class ExerciseFive
    {
        public void exerciseFive()
        {
            string numbers;
            
            Console.WriteLine("Enter a series of numbers: ");
            numbers = Console.ReadLine();

            int[] numberArray = numbers.Split(',').Select(n => int.Parse(n)).ToArray();

            Console.WriteLine(numberArray.Max());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //ExerciseOne exOne = new ExerciseOne();
            //exOne.exerciseOne();

            //ExerciseTwo exTwo = new ExerciseTwo();
            //exTwo.exerciseTwo();

            //ExerciseThree exThree = new ExerciseThree();
            //exThree.exerciseThree();

            //ExerciseFour exFour = new ExerciseFour();
            //exFour.exerciseFour();

            //ExerciseFive exFive = new ExerciseFive();
            //exFive.exerciseFive();
        }
    }
}
