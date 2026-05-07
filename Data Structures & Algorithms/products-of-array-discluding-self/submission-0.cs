public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
        int val=1;
        for(int i=0; i<nums.Length; i++)
        {
            result[i] = val;
            val *= nums[i];
        }
        val = 1;
        for(int i=nums.Length-1; i>=0; i--)
        {
            result[i] *= val;
            val *= nums[i];
        }   
        return result;
    }
}
