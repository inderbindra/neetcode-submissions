public class Solution {
    public int LargestRectangleArea(int[] heights) {
        Stack<(int height, int index)> stack = new();
        (int height, int index) item = (0, 0);
        int index=0, area=0, maxArea=0;
        for(int i=0; i<heights.Length; i++)
        {
            index = i;
            while(stack.Count > 0 && stack.Peek().height > heights[i])
            {
                item = stack.Pop();
                area = item.height * (i - item.index);
                maxArea = Math.Max(maxArea, area);
                index = item.index;
            }
            stack.Push((heights[i], index));
        }
        while(stack.Count > 0)
        {
            item = stack.Pop();
            area = item.height * (heights.Length - item.index);
            maxArea = Math.Max(maxArea, area);
        }
        return maxArea;
    }
}