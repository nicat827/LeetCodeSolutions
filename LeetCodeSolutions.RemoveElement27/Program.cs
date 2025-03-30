using System.Globalization;

int RemoveElement(int[] nums, int val)
{
    int idx = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != val)
        {
            nums[idx] = nums[i];
            idx++;
        }
    }
    for (int i = 0; i < nums.Length; i++)
    {
        Console.WriteLine(nums[i]);
    }
    return idx;
}

int[] input = new int[] { 1,2,2,4,5,2,3,2 };
int output = RemoveElement(input, 2);



//Console.WriteLine(output);