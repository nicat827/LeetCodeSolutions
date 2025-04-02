bool IsPalindrome(int x)
{
    int original = x;
    
    int reversed = 0;
    while (x != 0)
    {
        int remainder = x % 10;
        reversed = reversed * 10 + remainder;
        x /= 10;
    }
    return reversed == original;

}

bool res = IsPalindrome(-121);
Console.WriteLine(res);