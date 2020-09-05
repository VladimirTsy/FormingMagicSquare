using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

public class Program
{ 
    


    private static void Main()
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] s = new int[3][];

        for (int i = 0; i < 3; i++)
        {
            s[i] = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp));
        }

        int result = FormingMagicSquare(s);

        Console.WriteLine(result);
        Console.ReadKey();

       // textWriter.Flush();
       // textWriter.Close();
    }


    // Complete the formingMagicSquare function below.
    public static int FormingMagicSquare(int[][] s)
    {
        int[,,] arrAll = new int[8, 3, 3] {
                                           { { 4, 3, 8 }, { 9, 5, 1 }, { 2, 7, 6 } },
                                           { { 2, 9, 4 }, { 7, 5, 3 }, { 6, 1, 8 } },
                                           { { 6, 7, 2 }, { 1, 5, 9 }, { 8, 3, 4 } },
                                           { { 8, 1, 6 }, { 3, 5, 7 }, { 4, 9, 2 } },
                                           { { 6, 1, 8 }, { 7, 5, 3 }, { 2, 9, 4 } },
                                           { { 2, 7, 6 }, { 9, 5, 1 }, { 4, 3, 8 } },
                                           { { 4, 9, 2 }, { 3, 5, 7 }, { 8, 1, 6 } },
                                           { { 8, 3, 4 }, { 1, 5, 9 }, { 6, 7, 2 } }
                                        };

        int sum = 0, minDiff = 0;

        if (s[1][1] != 5)
        {
            sum = Math.Abs(s[1][1] - 5);
            s[1][1] = s[1][1] + sum;
        }

        for(int i = 0; arrAll.GetLength(0) > i; i++) {

            int diff = 0;
            // corners
            diff += Math.Abs(arrAll[i, 0, 0] - s[0][0]);
            diff += Math.Abs(arrAll[i, 0, 2] - s[0][2]);
            diff += Math.Abs(arrAll[i, 2, 0] - s[2][0]);
            diff += Math.Abs(arrAll[i, 2, 2] - s[2][2]);
            
            // between corners //

            diff += Math.Abs(arrAll[i, 0, 1] - s[0][1]);
            diff += Math.Abs(arrAll[i, 1, 0] - s[1][0]);
            diff += Math.Abs(arrAll[i, 2, 1] - s[2][1]);
            diff += Math.Abs(arrAll[i, 1, 2] - s[1][2]);



            if (i == 0) minDiff = diff;

            if (diff < minDiff) 
            { 
                minDiff = diff;
              
            }
        }

      

        return minDiff + sum;

    }



}