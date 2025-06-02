using System;

public class matrixProblem
{
    public static void getAvg()
    {
        int[,] mat = new int[2, 5];

        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.WriteLine($"Enter the {j}th number");
                mat[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int group1 = 0;
        int group2 = 0;

        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                if (i == 0)
                {
                    group1 += mat[i, j];
                }
                else if (i == 1)
                {
                    group2 += mat[i, j];
                }
            }
        }

        group1 = group1 / 5;
        group2 = group2 / 5;

        Console.WriteLine($"The group1 average is {group1}");
        Console.WriteLine($"The group2 average is {group2}");
    }
}
