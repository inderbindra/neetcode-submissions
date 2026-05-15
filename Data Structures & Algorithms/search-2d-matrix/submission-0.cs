public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int top=0, bottom=matrix.Length-1, left=0, right=matrix[0].Length-1, midR=0, mid=0;

        while(top <= bottom)
        {
            midR = (top + bottom)/2;

            if(target > matrix[midR][right])
            {
                top = midR + 1;
            }
            else if(target < matrix[midR][left])
            {
                bottom = midR - 1;
            }
            else
            {
                break;
            }
        }
        if(top > bottom)
        {
            return false;
        }

        while(left <= right)
        {
            mid = (left + right)/2;
            
            if(target == matrix[midR][mid])
            {
                return true;
            }
            else if(target > matrix[midR][mid])
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return false;
    }
}
