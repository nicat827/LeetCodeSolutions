int MajorityElement(int[] nums)
{
    int majority = nums[0];
    int count = 1;
    for (int i = 1; i < nums.Length; i++)
    {
        if (count == 0)
            majority = nums[i];

        if (nums[i] == majority)
            count++;
        else
            count--;
    }
    return majority;
}

int[] input = new int[] { 1 };
int output = MajorityElement(input);

Console.WriteLine(output);