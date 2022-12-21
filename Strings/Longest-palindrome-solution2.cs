// 409. Longest Palindrome
// https://leetcode.com/problems/longest-palindrome/description/

public class Solution {
    public int LongestPalindrome(string s) {
        HashSet<char> seen = new HashSet<char>();
        int count = 0;
        foreach(var ch in s){
            if(seen.Contains(ch)){
                count++;
                seen.Remove(ch);
            }
            else
                seen.Add(ch);
        }
        if(seen.Count != 0) return 2*count+1;
        return 2*count;
    }
}