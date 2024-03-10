using System.Numerics;

static int Grow(int[] x)
{
    var total = x[0];
    for (int i = 0; i < x.Length - 1; i++)
    {
         total *=  x[i + 1];
    }
    return total;
}

Console.WriteLine(Grow([1, 2, 3, 4]));
