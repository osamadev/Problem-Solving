// 76. Minimum Window Substring
// https://leetcode.com/problems/minimum-window-substring/description/

public class Solution {
    public string MinWindow(string s, string t) {
        if(s == t) return s;
        int n = s.Length;
        int m = t.Length;
        int[] dict = new int[128];
        for(int i=0; i < t.Length; i++){
            dict[t[i]] += 1;
        }
        int counter=m, begin=0, end=0, d=int.MaxValue, head=0;
        while(end < n){
            if(dict[s[end++]]-->0) counter--; 
            while(counter==0){ 
                if(end-begin<d)  d=end-(head=begin);
                if(dict[s[begin++]]++==0) counter++;  
            }  
        }
        return d==int.MaxValue? "":s.Substring(head, d);
    }

    private bool ContainsSubstring(string substr, Dictionary<char, int> targetDict, string t){
        if(substr.Length < t.Length) return false;
        var dict = new Dictionary<char, int>();
        for(int i=0; i < substr.Length; i++){
            if(!dict.ContainsKey(substr[i])) 
                dict[substr[i]] = 1;
            else 
                dict[substr[i]] += 1;
        }
        for(int k=0; k < t.Length; k++){
            if(!dict.ContainsKey(t[k]) || (dict.ContainsKey(t[k]) && targetDict[t[k]] != dict[t[k]])) return false;
        }
        return true;
    }
}