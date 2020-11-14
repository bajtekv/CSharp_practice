using System;

namespace kata2
{
    /*  Write a function that accepts an array of 
     *  10 integers (between 0 and 9), that returns a 
     *  string of those numbers in the form of a phone number.
     *  Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
     */
    class Program
    {
        static void Main()
        {
            Console.WriteLine(CreatePhoneNumber(new int[] { 1, 3, 1, 0, 1, 3, 7, 3, 9, 1 }));
            Console.ReadLine();
        }
        public static string CreatePhoneNumber(int[] numbers)
        {
            if (numbers.Length != 10)
            {
                return null;
            }
            string formattedNumber = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    formattedNumber += "(";
                    formattedNumber += numbers[i];
                }
                else if (i == 3)
                {
                    formattedNumber += ") ";
                    formattedNumber += numbers[i];
                }
                else if (i == 6)
                {
                    formattedNumber += "-";
                    formattedNumber += numbers[i];
                }
                else
                {
                    formattedNumber += numbers[i];
                }
            }
            return formattedNumber;
        }
        public static string CreateNumber2(int[] numbers) //great code by cinq
        {
            return String.Format("{0:(000) 000-0000}", ulong.Parse(string.Join("", numbers)));
        }
    }
}
