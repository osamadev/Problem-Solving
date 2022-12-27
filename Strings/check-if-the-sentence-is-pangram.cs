// 1832. Check if the Sentence Is Pangram
// https://leetcode.com/problems/check-if-the-sentence-is-pangram/description/

public class Solution {
    public bool CheckIfPangram(string sentence) {
        if(sentence.Length < 26) return false;
        HashSet<char> seen = new HashSet<char>();
        for(int i=0; i < sentence.Length; i++){
            seen.Add(sentence[i]);
        }
        return (seen.Count == 26);
    }
}