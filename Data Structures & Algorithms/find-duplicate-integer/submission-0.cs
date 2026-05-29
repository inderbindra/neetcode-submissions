public class Solution {
    public int FindDuplicate(int[] nums) {
        Array.Sort(nums);
        int i;
        for(i=0; i<nums.Length; i++)
        {
            if(Math.Abs(i - nums[i]) == 0)
            {
                break;
            }
        }
        return nums[i];
    }
}
