static double SumArray(double[] array)
{
    return array.Length == 0 ? 0 : array.Sum();
}

Console.WriteLine(SumArray([1, 5.2, 4, 0, -1]));