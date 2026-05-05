public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> hashMap = new();
        int diff=0;

        for(int i=0; i<nums.Length; i++)
        {
            diff = target - nums[i];

            if(hashMap.ContainsKey(diff))
            {
                return new int[]{hashMap[diff], i};
            }
            hashMap.TryAdd(nums[i], i);
        }
        return null;
    }
}
