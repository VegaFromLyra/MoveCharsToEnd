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

            Console.WriteLine("Updated character array is");

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
            }

            Console.WriteLine();
        }

        static void MoveLettersToEnd(char[] input, char letter)
        {
            int length = input.Length;

            int count = 0;

            // First count the number of occurences
            // of given letter
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == letter)
                {
                    count++;
                }
            }

            // x is a pointer to the 
            // characters that are not equal to letter
            int x = 0;

            // y is a pointer to the letter bases chars
            int y = 0;

            // This moves the non letter values 
            // towards the left
            while (x < length - count)
            {
                if (input[y] != letter)
                {
                    input[x] = input[y];
                    x++;
                    y++;
                }
                else
                {
                    while ((y < length) && (input[y] == letter))
                    {
                        y++;
                    }
                }
            }

            while (x < length)
            {
                input[x] = letter;
                x++;
            }
        }
    }
}
