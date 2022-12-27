// 91. Decode Ways
// https://leetcode.com/problems/decode-ways/description/

public class Solution {
    public int NumDecodings(string s) {
        if(s.StartsWith("0"))
            return 0;
        int[] memo = new int[s.Length];
        Array.Fill(memo, -1);
        return NumDecodings(s, 0, memo);
    }

    public int NumDecodings(string s, int idx, int[] memo){
        if(idx == s.Length) return 1;
        if(s[idx] == '0') return 0;
        if(memo[idx] != -1)
            return memo[idx];
        int res = NumDecodings(s, idx+1, memo);
        if(idx < s.Length-1 && (s[idx] == '1' || (s[idx] == '2') && int.Parse(s[idx+1].ToString()) <= 6))
            res += NumDecodings(s, idx+2, memo);
        return memo[idx] = res;
    }
}

