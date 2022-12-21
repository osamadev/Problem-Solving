// 205. Isomorphic Strings
// https://leetcode.com/problems/isomorphic-strings/description/

public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if(s.Length != t.Length) return false;
        var dict1 = new Dictionary<char, char>();
        var dict2 = new Dictionary<char, char>();
        for(int i=0; i < s.Length; i++){
            if(dict1.ContainsKey(s[i]) && t[i] != dict1[s[i]]) return false;
            if(dict2.ContainsKey(t[i]) && s[i] != dict2[t[i]]) return false;
            dict1[s[i]] = t[i];
            dict2[t[i]] = s[i];
        }
        return true;
    }
}