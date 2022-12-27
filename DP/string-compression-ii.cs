// 1531. String Compression II
// https://leetcode.com/problems/string-compression-ii/description/

public class Solution {
    public int GetLengthOfOptimalCompression(string s, int k) {
        int[][] dp = new int[s.Length+1][];
        for(int i=0; i < dp.GetLength(0); i++){
            dp[i] = new int[k+1];
            Array.Fill(dp[i], -1);
        }
        return GetLengthOfOptimalCompressionRec(s, 0, k, dp);
    }

    public int GetLengthOfOptimalCompressionRec(string s, int idx, int K, int[][] dp) {
        if(K < 0) return int.MaxValue;
        int k = K;
        if(s.Length - idx <= k) return 0;
        if(dp[idx][k] >= 0) return dp[idx][k];
        int res = GetLengthOfOptimalCompressionRec(s, idx + 1, k - 1, dp);
        int c = 1;
        for(int i = idx + 1; i <= s.Length; ++i) {
            res = Math.Min(res, 
            GetLengthOfOptimalCompressionRec(s, i, k, dp) + 1 + (c >= 100 ? 3 : (c >= 10 ? 2 : (c > 1 ? 1 :0))));
            if(i == s.Length) break;
            if(s[i] == s[idx]) ++c;
            else if(--k < 0) break;
        }
        return dp[idx][K] = res;
    }

    private int GetLengthAfterCompression(string s){
        if(s is null || s.Length == 0) return 0;
        var prevChar = s[0];
        int sameCharCount = 1;
        var sb = new StringBuilder();
        for(int i=1; i < s.Length; i++){
            if(prevChar == s[i]){
                sameCharCount++;
                if(i == s.Length-1){
                    sb.Append(prevChar.ToString());
                    if(sameCharCount > 1)
                        sb.Append(sameCharCount.ToString());
                }
            }
            else{
                sb.Append(prevChar.ToString());
                if(sameCharCount > 1)
                    sb.Append(sameCharCount.ToString());
                sameCharCount = 1;
                prevChar = s[i];
            }
        }
        if(sameCharCount == 1)
            sb.Append(prevChar.ToString());
        return sb.Length;
    }
}