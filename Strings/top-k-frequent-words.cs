// 692. Top K Frequent Words
// https://leetcode.com/problems/top-k-frequent-words/description/

public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
        SortedDictionary<string, int> dict = new SortedDictionary<string, int>();
        for(int i=0; i < words.Length; i++){
            if(dict.ContainsKey(words[i]))
                dict[words[i]] += 1;
            else
                dict[words[i]] = 1; 
        }
        return dict.OrderByDescending(kvp => kvp.Value).Take(k).Select(kvp => kvp.Key).ToList();
    }
}


