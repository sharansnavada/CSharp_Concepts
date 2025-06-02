using System;

public class rowandcol
{
    public static void Print()
    {
        char[,] mat = new char[20, 70];

        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                mat[i, j] = 'x';
            }
        }

        int counter = 0;
        foreach (char c in mat)
        {
            if (counter % 70 == 0)
            {
                Console.WriteLine(" ");
            }
            Console.Write(c);
            counter++;
        }
        // char[,] mat = new char[20, 70];

        // for (int i = 0; i < mat.GetLength(0); i++)
        // {
        //     for (int j = 0; j < mat.GetLength(1); j++)
        //     {
        //         Console.Write("x");
        //     }
        //     Console.WriteLine(" ");
        // }

    }

}
