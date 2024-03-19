static int ArrayPlusArray(int[] arr1, int[] arr2)
{
    return arr1.Sum() + arr2.Sum();
}

Console.WriteLine(ArrayPlusArray(new int[] { 100, 200, 300 }, new int[] { 400, 500, 600 }));