// 49. Group Anagrams
// https://leetcode.com/problems/group-anagrams/description/

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        IList<IList<string>> res = new List<IList<string>>();
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        foreach(var str in strs){
            var sortedStr = String.Concat(str.OrderBy(x => x));
            if(dict.ContainsKey(sortedStr)){
                    dict[sortedStr].Add(str);
                    dict[sortedStr] = dict[sortedStr];
            }
            else
                dict.Add(sortedStr, new List<string>{str});
        }
        foreach(var v in dict.Values)
            res.Add(v);
        return res;
    }
}