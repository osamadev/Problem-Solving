// 392. Is Subsequence
// https://leetcode.com/problems/is-subsequence/description/

public class Solution {
    public bool IsSubsequence(string s, string t) {
        return IsSubsequence(s, t, 0, 0);
    }

    public bool IsSubsequence(string s, string t, int i, int j){
        if(i == s.Length) return true;
        if(j == t.Length) return false;
        if(s[i] == t[j])
            return IsSubsequence(s, t, i+1, j+1);
        else
            return IsSubsequence(s, t, i, j+1);
    }
}