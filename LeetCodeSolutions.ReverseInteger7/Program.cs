using System.Numerics;

int Reverse(int x)
{
    if (x >= int.MaxValue || x <= int.MinValue) return 0;
    int original = x;
    int reversed = 0;
    int count = 0;
    int currentReminder = 0;
    while (x != 0)
    {
        count++;
        currentReminder = x % 10;
        int newVal = reversed * 10 + currentReminder;
        if (newVal < reversed && reversed > 0) return 0;
        if (newVal > reversed && reversed < 0) return 0;
        reversed = newVal;
        x /= 10;
    }
    if (count == 10 && original % 10 > 2) return 0;
    return reversed;
}
int res = Reverse(1563847412);
Console.WriteLine(res);