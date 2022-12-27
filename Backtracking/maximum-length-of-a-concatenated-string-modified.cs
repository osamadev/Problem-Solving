// 1239. Maximum Length of a Concatenated String with Unique Characters
// https://leetcode.com/problems/maximum-length-of-a-concatenated-string-with-unique-characters/description/

public class Solution {
    int maxLen = int.MinValue;
    public int MaxLength(IList<string> arr) {
        var sb = new StringBuilder();
        backtrack(0, sb, arr);
        return maxLen;
    }

    private void backtrack(int idx, StringBuilder sb, IList<string> arr) {
        if(idx == arr.Count){
            maxLen = Math.Max(maxLen, sb.Length);
            return;
        }
        sb.Append(arr[idx]);
        if(!ContainsCharDuplicates(sb))
            backtrack(idx+1, sb, arr);
        sb.Remove(sb.Length - arr[idx].Length, arr[idx].Length);
        backtrack(idx+1, sb, arr);
    }

    private bool ContainsCharDuplicates(StringBuilder sb){
        var seen = new HashSet<char>();
        foreach(var ch in sb.ToString()){
            if(!seen.Add(ch)) return true;
        }
        return false;
    }
}