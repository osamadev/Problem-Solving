// 392. Is Subsequence
// https://leetcode.com/problems/is-subsequence/description/

public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(s.Length == 0) return true;
        int i = 0, j=0;
        while(j < t.Length){
            if(s[i] == t[j]){
                i++;
                j++;
            }
            else
                j++;
            if(i == s.Length) return true;
        }
        return false;
    }
}