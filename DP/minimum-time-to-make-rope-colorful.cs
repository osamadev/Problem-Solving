// 1578. Minimum Time to Make Rope Colorful
// https://leetcode.com/problems/minimum-time-to-make-rope-colorful/description/

public class Solution {
    public int MinCost(string colors, int[] neededTime) {
        int[] dp = new int[colors.Length];
        for(int i=1; i < colors.Length; i++){
            if(colors[i] == colors[i-1]){
                dp[i] = dp[i-1] + Math.Min(neededTime[i], neededTime[i-1]);
                if(neededTime[i-1] > neededTime[i])
                    neededTime[i] = neededTime[i-1];
            }
            else
                dp[i] = dp[i-1];
        }
        return dp[colors.Length-1];
    }
}
