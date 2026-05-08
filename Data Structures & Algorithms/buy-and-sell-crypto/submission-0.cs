public class Solution {
    public int MaxProfit(int[] prices) {
        int left=0, right=1;
        int profit=0, maxProfit=0;

        while(right< prices.Length)
        {
            if(prices[left] >= prices[right])
            {
                left = right;
            }
            else
            {
                profit = prices[right] - prices[left];
                maxProfit = Math.Max(maxProfit, profit);
            }
            right++;
        }
        return maxProfit;
    }
}
