using System;
using System.Collections.Generic;

namespace RomanConverter
{
    public class Program
    {
        private static IDictionary<char, int> RomanDictionary = new Dictionary<char, int> {
            { 'i', 1 },
            { 'v', 5 },
            { 'x', 10 },
            { 'l', 50 },
            { 'c', 100 },
            { 'd', 500 },
            { 'm', 1000 }
        };

        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 1)
                {

                    var result = Parser(args[0]);
                    Console.WriteLine(result);
                } else
                {
                    Console.WriteLine("Enter one roman numeral");
                }
            } catch (KeyNotFoundException)
            {
                Console.WriteLine("Invalid roman syntax");
            }
        }

        public static int Parser(string roman)
        {
            roman = roman.ToLower();
            int sum = 0;
            char[] letters = roman.ToCharArray();
            for (int i = 0; i < letters.Length; i ++)
            {
                var letter1 = RomanDictionary[letters[i]];
                i = i + 1;
                var letter2 = GetNextLetter(letters, i);
                sum += Calculate(letter1, letter2);
            }
            return sum;
        }

        public static int GetNextLetter(char[] letters, int index)
        {
            if (index < letters.Length)
            {
                return RomanDictionary[letters[index]];
            }
            return 0;
        }

        public static int Calculate(int digit1, int digit2)
        {
            if (digit1 < digit2)
            {
                return digit2 - digit1;
            }
            return digit2 + digit1;
        }
    }
}
