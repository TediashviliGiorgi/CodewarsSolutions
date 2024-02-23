using Sol6;

int[][] array = new int[][]
        {
            new int[] { 0, 1, 2, 3, 4 },
            new int[] { 10, 11, 12, 13, 14 },
            new int[] { 20, 21, 22, 23, 24 },
            new int[] { 30, 31, 32, 33, 34 }
        };

string result = Solution.ToCsvText(array);
Console.WriteLine(result);
