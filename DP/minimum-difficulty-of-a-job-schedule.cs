// 1335. Minimum Difficulty of a Job Schedule
// https://leetcode.com/problems/minimum-difficulty-of-a-job-schedule/description/

public class Solution {
    public int MinDifficulty(int[] jobDifficulty, int d) {
        if(jobDifficulty.Length < d) return -1;
        int[][] memo = new int[jobDifficulty.Length][];
        for(int i=0; i < memo.Length; i++){
            memo[i] = new int[d+1];
            Array.Fill(memo[i], -1);
        }
        return MinDifficultyRec(jobDifficulty, 0, d, memo);
    }

    public int MinDifficultyRec(int[] jobDifficulty, int idx, int d, int[][] memo){
        if(d == 0 && idx == jobDifficulty.Length) return 0;
        if(d == 0 || idx == jobDifficulty.Length) return int.MaxValue;
        if(memo[idx][d] != -1) return memo[idx][d];
        int currMax = jobDifficulty[idx];
        int minDiff = int.MaxValue;
        for(int i=idx; i < jobDifficulty.Length; i++){
            currMax = Math.Max(currMax, jobDifficulty[i]);
            var tempMin = MinDifficultyRec(jobDifficulty, i+1, d-1, memo);
            if(tempMin != int.MaxValue)
                minDiff = Math.Min(minDiff,tempMin + currMax);
        }
        return memo[idx][d] = minDiff;
    }
}

