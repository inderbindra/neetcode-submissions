public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        int left=0, right = nums.Length-1, sum=0;
        List<List<int>> result = new();
        Array.Sort(nums);
        for(int i=0; i<nums.Length; i++)    
        {
            if(i>0 && nums[i] == nums[i-1])   
            {
                continue;
            }
            left = i+1;
            right = nums.Length-1;
            while(left < right)
            {
                sum = nums[i] + nums[left] + nums[right];
                if(sum == 0)
                {
                    result.Add(new List<int> {nums[i], nums[left], nums[right]});
                    left++;
                    while(left < right && nums[left] == nums[left-1])
                    {
                        left++;
                    }
                }
                else if(sum > 0)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
        }
        return result;
    }
}
