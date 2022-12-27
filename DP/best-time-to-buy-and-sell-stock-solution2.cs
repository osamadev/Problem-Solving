// 121. Best Time to Buy and Sell Stock
// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/

public class Solution {
    //Example: [7,1,5,3,6,4]
    public int MaxProfit(int[] prices) {
        int minBuy = int.MaxValue;
        int profit = 0;
        for(int i=0; i < prices.Length; i++)
        {
            minBuy = Math.Min(prices[i], minBuy);
            profit = Math.Max(profit, prices[i] - minBuy);
        }
        return profit;
    }
}