public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if(nums1.Length > nums2.Length)
        {
            return FindMedianSortedArrays(nums2, nums1);
        }
        int x = nums1.Length;
        int y = nums2.Length;
        int totalLength = x + y;
        /*
        Why right = x and not x-1?
        We binary search partition positions, not indices.
        For an array of length x, there are: x + 1 possible partition positions.
        Possible partitions:

        | 1 3 8      partition at 0
        1 | 3 8      partition at 1
        1 3 | 8      partition at 2
        1 3 8 |      partition at 3

        Notice:
        Array length = 3
        Partition positions = 4
        */
        int midX =0, midY=0, left=0, right = x;
        int leftX=0, rightX=0, leftY=0, rightY=0;
        double median = 0.0;
        // left <= right?
        while(left <= right)
        {
            midX = (left + right)/2;
            // why (totalLength + 1)? Adding 1 helps in calculating the mid for both even & odd lengths.
             /*
            Why 1 is added to total Length (x+y)?
            We want Left side contains HALF the elements
            BUT for odd length arrays:
            Left side must contain one extra element
            because median belongs to left partition.

            For odd Length: (7 + 1)/2 = 4

            For even Length: (8 + 1)/2 = 4

            Adding 1 unifies both cases.
            */
            midY = (totalLength + 1)/2 - midX;

            leftX = (midX == 0)? int.MinValue : nums1[midX-1];
            rightX = (midX == x)? int.MaxValue : nums1[midX];
            
            leftY = (midY == 0)? int.MinValue : nums2[midY-1];
            rightY = (midY == y)? int.MaxValue : nums2[midY];

            if(leftX <= rightY && leftY <= rightX)
            {
                if(totalLength % 2 == 0)
                {
                    median = (Math.Max(leftX, leftY) + Math.Min(rightX, rightY)) /(2.0);
                }
                else
                {
                    median = Math.Max(leftX, leftY);
                }
                break;
            }
            else if(leftX > rightY)
            {
                right = midX - 1;
            }
            else
            {
                left = midX + 1;
            }
        }
        return median;
    }
}