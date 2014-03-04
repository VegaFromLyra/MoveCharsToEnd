using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Given an array of letters, and another letter in the array 'l', update the array so that all letters with value 'l' are on the right side of the array. 
//For example: a, b, c, d, a, b and letter a => b, c, d, b, a, a 

namespace MoveCharsToEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = { 'a', 'b', 'c', 'd', 'a', 'b' };
            char letter = 'a';

            MoveLettersToEnd(input, letter);
        }

        static void MoveLettersToEnd(char[] input, char letter)
        {
            String inputStr = new String(input);
            StringBuilder sb = new StringBuilder(inputStr);

            int count = 0;

            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == letter)
                {
                    count++;
                    sb.Remove(i, 1);
                }
            }

            string temp = null;
            for(int i = 0; i < count; i++)
            {
                temp += letter;
            }

            sb.Append(temp);

            Console.WriteLine("Result is {0}", sb.ToString());
        }
    }
}
