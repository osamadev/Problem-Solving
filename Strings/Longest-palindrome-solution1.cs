// 409. Longest Palindrome
// https://leetcode.com/problems/longest-palindrome/description/

public class Solution {
    public int LongestPalindrome(string s) {
        var freq = new Dictionary<char, int>();
        int longestPal=0;
        bool isInMiddle = true;
        foreach(var ch in s){
            if(freq.ContainsKey(ch))
                freq[ch] += 1;
            else
                freq[ch] = 1;
        }

        foreach(var kvp in freq){
            if(kvp.Value % 2 == 0)
                longestPal += kvp.Value;
            else{
                if(isInMiddle)
                    longestPal += kvp.Value;
                else
                    longestPal += kvp.Value-1;
                isInMiddle = false;
            }
        }
        return longestPal;
    }
}
