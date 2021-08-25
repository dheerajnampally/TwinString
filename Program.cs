using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinString
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("/*Checking if two strings are Twins*/");

            Console.WriteLine("Enter first String");
            string FirstString = Console.ReadLine();

            Console.WriteLine("Enter second String");
            string SecondString = Console.ReadLine();

            if(IsTwinString(FirstString, SecondString))
                Console.WriteLine("Two strings are twins !!");
            else
                Console.WriteLine("Two strings are not twins !!");

            Console.ReadLine();

            Console.WriteLine("/*Checking if either of numbers equals to 1 or sum of both is 5*/");

            Console.WriteLine("Enter first number");
            int FirstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int SecondNumber = int.Parse(Console.ReadLine());

            if (ReturnTrueOnConditions(FirstNumber, SecondNumber))
                Console.WriteLine("Either of the numbers is 1 or sum of both is 5");
            else
                Console.WriteLine("Neither of the numbers is 1 nor sum of both is 5");

            Console.ReadLine();

        }
        public static bool IsTwinString(string s1, string s2)
        {
            // Check if string is null or empty if yes then no need to go further
            // May be normalize for Special characters(for example é)
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
                return false;
            // Check if strings are not of same length. If the lengths are not same then no need to go further
            if (s1.Length != s2.Length)
                return false;

            /* Real logic is to compare if two strings are simillar
                    Solution 1 : Hard check all the characters one by one
                    Solution 2 : Put all the characters in to a array and then sort and then compare 
                    Solution 3 : Put all the characters in to a array and then sort and then compare
             */

            // Solution 1 : Hard check all the characters one by one
            //foreach (char c in s2)
            //{
            //    int i = s1.IndexOf(c);
            //    if (i >= 0)
            //        s1 = s1.Remove(i, 1);
            //    else
            //        return false;
            //}

            //return string.IsNullOrEmpty(s1);

            // Solution 2 : Put all the characters in to a array and then sort and then compare
            //var ArrayS1 = s1.ToLower().ToCharArray();
            //var ArrayS2 = s2.ToLower().ToCharArray();
            //Array.Sort(ArrayS1);
            //Array.Sort(ArrayS2);
            //return (ArrayS1 == ArrayS2);

            //  Solution 3. LINQ
            return s1.OrderBy(a => a).SequenceEqual(s2.OrderBy(a => a));
           
        }

        public static bool ReturnTrueOnConditions(int i, int j)
        {
            // Return true if either of parameters equals to 1 or sum of both is 5
            return ((i == 1 || j == 1) || i + j == 5) ;

        }
    }
}
