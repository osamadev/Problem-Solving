// 1155. Number of Dice Rolls With Target Sum
// https://leetcode.com/problems/number-of-dice-rolls-with-target-sum/description/

public class Solution {
    public int NumRollsToTarget(int n, int k, int target) {
        long[,] memo = new long[n+1, target+1];
        for(int i=0; i < memo.GetLength(0); i++){
            for(int j=0; j < memo.GetLength(1); j++)
                memo[i,j] = -1;
        }
        return (int)NumRollsToTargetRec(0, n, k, target, memo);
    }

    public long NumRollsToTargetRec(int t, int n, int k, int target, long[,] memo) {
        if(target < 0 || t > n) return 0;
        if(t == n && target == 0) return 1;
        if(memo[t, target] != -1)
            return memo[t,target];
        long res = 0;
        for(int i=1; i <= k; i++){
                res += (NumRollsToTargetRec(t + 1, n, k, target-i, memo) % 1000000007);
        }
        return memo[t, target] = res % 1000000007;
    }
}