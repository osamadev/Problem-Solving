// 443. String Compression
// https://leetcode.com/problems/string-compression/description/

public class Solution {
    public int Compress(char[] chars) {
        var prevChar = chars[0];
        int sameCharCount = 1;
        var sb = new StringBuilder();
        for(int i=1; i < chars.Length; i++){
            if(prevChar == chars[i]){
                sameCharCount++;
                if(i == chars.Length-1){
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
                prevChar = chars[i];
            }
        }
        if(sameCharCount == 1)
            sb.Append(prevChar.ToString());
        for(int i=0; i < sb.Length; i++){
            if(chars[i] != sb[i])
                chars[i] = sb[i];
        }
        chars = chars.Where((i, x) => i < sb.Length).ToArray();
        return sb.Length;
    }
}