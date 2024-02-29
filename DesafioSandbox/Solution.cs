using System.Reflection.Metadata;

public class Solution
{
    public static int RemoveDuplicates(int[] nums)
    {
        int joker = nums[0] - 1;
        int reps = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == joker) { continue; }
            if (nums[i] == nums[i - 1])
            {
                nums[i] = joker;
                reps++;
            }
        }
        if (reps == 0) { return nums.Length; }
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == joker)
            {
                for (int j = i; j < nums.Length - 1 && nums[j + 1] != joker; j++)
                {
                    nums[i] = nums[i + 1];
                    nums[i + 1] = joker;
                }
            }
        }
        return nums.Length - reps;
    }
}