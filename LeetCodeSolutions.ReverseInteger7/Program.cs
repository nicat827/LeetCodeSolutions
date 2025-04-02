int Reverse(int x)
{
    if (x >= int.MaxValue || x <= int.MinValue) return 0;
    int reversed = 0;
    while (x != 0)
    {
        reversed = reversed * 10 + x % 10;
        x /= 10;
    }
    if (reversed >= int.MaxValue || reversed <= int.MinValue) return 0;
    return reversed;
}
int res = Reverse(-123);
Console.WriteLine(res);