internal class Class1
{
  // Main Method
  // C# implementation of the approach GFG

    static int a = 2, b = 4;

    // Function that compares both the arrays
    // and returns -1, 0 and 1 accordingly
    static int compareRow(int[] a1, int[] a2)
    {
        for (int i = 0; i < b; i++)
        {
            // Return 1 if mid row is less than arr[]
            if (a1[i] < a2[i])
                return 1;

            // Return 1 if mid row is greater than arr[]
            else if (a1[i] > a2[i])
                return -1;
        }
        // Both the arrays are equal
        return 0;
    }
    // Function to find a row in the
    // given matrix using binary search
    static int binaryCheck(int[,] ar, int[] arr)
    {
        int l = 0, r = b - 1;
        while (l <= r)
        {
            int mid = (l + r) / 2;
            int temp = compareRow(GetRow(ar, mid), arr);

            // If current row is equal to the given
            // array then return the row number
            if (temp == 0)
                return mid + 1;

            // If arr[] is greater, ignore left half
            else if (temp == 1)
                l = mid + 1;

            // If arr[] is smaller, ignore right half
            else
                r = mid - 1;
        }

        // No valid row found
        return -1;
    }

    public static int[] GetRow(int[,] matrix, int row)
    {
        var rowLength = matrix.GetLength(1);
        var rowVector = new int[rowLength];

        for (var i = 0; i < rowLength; i++)
            rowVector[i] = matrix[row, i];

        return rowVector;
    }

    // Driver code
    public static void Main(String[] args)
    {
        int[,] mat = {{ 0, 0, 1, 0 },
                { 10, 9, 22, 23 },
                { 40, 40, 40, 40 },
                { 43, 44, 55, 68 },
                { 81, 73, 100, 132 },
                { 100, 75, 125, 133 }};
        int[] row = { 10, 9, 22, 23 };
        Console.WriteLine(binaryCheck(mat, row));
    }
}
