// 392. Is Subsequence
// https://leetcode.com/problems/is-subsequence/description/

public class Solution {
    public bool IsSubsequence(string s, string t) {
        bool charExists = false;
        int curIdx = 0;
        for(int i=0; i < s.Length; i++){
            for(int j=curIdx; j < t.Length; j++){
                if(s[i] == t[j]) {
                    curIdx = j+1; 
                    charExists = true;
                    break;
                }
            }
            if(!charExists) return false;
            charExists = false;
        }
        return true;
    }
}