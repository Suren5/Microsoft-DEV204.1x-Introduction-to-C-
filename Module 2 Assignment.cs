using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingCodeTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int column = 0; column < 8; column++)  // generates 8 row x 8 column pattern
            {
                for (int row = 0; row < 8; row++)
                {
                    if ((row + column) % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    else if ((row + column) % 2 == 1)
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write("Neither X nor O");  // In case the logic for X and O fails
                    }
                }
                Console.WriteLine();
            }
        }
    }
}


/* 
Output:
XOXOXOXO
OXOXOXOX
XOXOXOXO
OXOXOXOX
XOXOXOXO
OXOXOXOX
XOXOXOXO
OXOXOXOX
*/


/// Module Two Assignment

/// For this assignment, you will create the pattern of a chess board that is 8 x 8.
/// Use X and O to represent the squares.
///     1.  Create the appropriate nested looping structure to output the characters in an 
///         8 x 8 grid on the screen using Console.Write() or Console.WriteLine() as appropriate.
///     2.  Include a decision structure to ensure that alternate rows start with opposite
///         characters as a real chess board alternates the colors among rows.

///    This is what your output should look like.
///    (NOTE: Depending on how this renders in your browser, you may see additional blank lines between the XOXO output.
///    It is not required in your output, just ensure each line is under the previous one.)
///    XOXOXOXO
///    OXOXOXOX
///    XOXOXOXO
///    OXOXOXOX
///    XOXOXOXO
///    OXOXOXOX
///    XOXOXOXO
///    OXOXOXOX

/// Grading Criteria:
///    Used a nested loop
///    Used a decision structure to flip row output
///    Output is correct per above image