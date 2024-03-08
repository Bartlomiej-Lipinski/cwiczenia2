Console.WriteLine("Hello World!");
Console.WriteLine(GetAvg([1,2,3]))
static double GetAvg(int[] arr)
{
    int sum = 0;
    foreach (var VARIABLE in arr)
    {
        sum += VARIABLE;
    }
    return (double)sum / arr.Length;
}