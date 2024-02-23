static int StringToNumber(string str)
{
    return int.TryParse(str, out int result) ? int.Parse(str) : -1;
}

Console.WriteLine(StringToNumber("12345")); 