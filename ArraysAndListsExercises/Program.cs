using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndListsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Write a program and continuously ask the user to enter different names, until the user presses Enter 
            /// (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
            var names = new List<string>();
            //while (true)
            //{
            //    console.writeline("enter a friend's name or press enter");
            //    var friends = console.readline();

            //    if (friends == "")
            //        break;
            //    names.add(friends);
            //}
            if (names.Count > 2)
                //Console.WriteLine(names[0] + ", " + names[1] + " and " + (names.Count -2) + " others like your post.");
                Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);

            else if ( names.Count == 2)
                //Console.WriteLine(names[0] + " and " + names[1] + " like your post.");
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);

            else if (names.Count == 1)
                Console.WriteLine(names[0] + " likes your post.");
            
            else
                Console.WriteLine("You have no likes!");

            /// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
            /// Display the reversed name on the console.

            //Console.WriteLine("Enter your name");
            //var input = Console.ReadLine();

            //char[] inputarray = input.ToCharArray();
            //Array.Reverse(inputarray);
            //string output = new string(inputarray);
            //Console.WriteLine("Your name reversed is: " + output);

            //LINQ method
            //string input = "hello world";
            //string output = new string(input.ToCharArray().Reverse().ToArray());

            /// Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display 
            /// an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
            /// and display the result on the console.

            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.WriteLine("Enter a number");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("You already entered " + number);
                    continue;
                }
                numbers.Add(number);
            }

            numbers.Sort();

            Console.WriteLine("Sorted numbers");
            foreach (var n in numbers)
                Console.Write(n);

            /// Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
            /// include duplicates. Display the unique numbers that the user has entered.

            var numsList = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number or type Quit to exit");
                var nums = Console.ReadLine();

                if (nums.ToLower() == "quit")
                    break;

                numsList.Add(Convert.ToInt32(nums));
            }

            var uniques = new List<int>();
            foreach(var n in numsList)
            {
                if (!uniques.Contains(n))
                    uniques.Add(n);
            }

            Console.WriteLine("Unique Numbers");
            foreach (var n in uniques)
                Console.WriteLine(n);

            /// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is 
            /// empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
            /// the 3 smallest numbers in the list.

            string[] elements;
            while (true)
            {
                Console.Write("Enter a list of comma-separated numbers: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List");
            }

            var listNums = new List<int>();
            foreach (var number in elements)
                listNums.Add(Convert.ToInt32(number));

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                // Assume the first number is the smallest
                var min = listNums[0];
                foreach (var number in listNums)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                listNums.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallests)
                Console.WriteLine(number);
        }
    }
}
