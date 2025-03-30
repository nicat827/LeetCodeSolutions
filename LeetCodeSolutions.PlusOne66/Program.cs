int[] PlusOne(int[] digits)
{
    bool isFirstNine = digits[0] == 9;
    bool isLastNine = digits[^1] == 9;
    int repeatNinesCount = 0;
    int lastNineIdx = -1;
    if (!isLastNine)
    {
        digits[^1]++;
        return digits;
    }

    for (int i = digits.Length - 1; i >= 0; i--)
    {
        if (digits[i] == 9 && (lastNineIdx == -1 || lastNineIdx - 1 == i))
        {
            lastNineIdx = i;
            repeatNinesCount++;
        }
    }
    if (digits.Length != repeatNinesCount)
    {
        digits[lastNineIdx - 1]++;
        for (int i = lastNineIdx; i < digits.Length; i++)
        {
            digits[i] = 0;
        }
    }
    else
    {
        Array.Resize(ref digits, digits.Length + 1);
        digits[0] = 1;
        for (int i = 1; i < digits.Length; i++)
        {
            digits[i] = 0;
        }

    }
    return digits;
    

}

int[] input = new int[] { 9, 9,9, 9 };
int[] output = PlusOne(input);

for (int i = 0; i < output.Length; i++)
{
    Console.WriteLine(output[i]);
}