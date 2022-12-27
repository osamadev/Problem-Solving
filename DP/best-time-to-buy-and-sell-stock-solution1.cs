// 121. Best Time to Buy and Sell Stock
// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/

public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int minBuy = prices[0];
        for(int i=1; i < prices.Length; i++){
            minBuy = Math.Min(minBuy, prices[i-1]);
            maxProfit = Math.Max(maxProfit, prices[i]- minBuy);
        }
        return maxProfit;
    }
}