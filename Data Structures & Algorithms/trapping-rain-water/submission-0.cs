public class Solution {
    public int Trap(int[] height) {
        int left=0, right=height.Length-1, leftMax=height[left], rightMax=height[right];
        int water=0;
        while(left < right)
        {
            if(leftMax < rightMax)
            {
                left++;
                leftMax = Math.Max(leftMax, height[left]);
                water += leftMax - height[left];
            }
            else
            {
                right--;
                rightMax = Math.Max(rightMax, height[right]);
                water += rightMax - height[right];
            }
        }
        return water;
    }
}
