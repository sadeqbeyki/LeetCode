namespace LeetCode;

public class TwoSum
{
    public int[] Zweisum(int[] nums, int target)
    {
        for (int numA = 0; numA < nums.Length; numA++)
        {
            for (int numB = numA + 1; numB < nums.Length; numB++)
            {
                if (nums[numA] + nums[numB] == target) 
                    return new int[] { numA, numB };
            }
        }
        throw new Exception("no two sum solution found");
    }
}
