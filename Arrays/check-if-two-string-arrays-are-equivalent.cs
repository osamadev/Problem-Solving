// 1662. Check If Two String Arrays are Equivalent
// https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/description/

public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        return string.Join("", word1) == string.Join("", word2);
    }
}