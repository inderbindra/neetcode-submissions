public class Solution {
    public int MaxArea(int[] heights) {
        int left =0, right=heights.Length-1;
        int area=0, maxArea=0;

        while(left < right)
        {
            area = Math.Min(heights[left], heights[right]) * (right - left);
            maxArea = Math.Max(maxArea, area);
            if(heights[left] < heights[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return maxArea;
    }
}
