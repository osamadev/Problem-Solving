// 49. Group Anagrams
// https://leetcode.com/problems/group-anagrams/description/

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        IList<IList<string>> res = new List<IList<string>>();
        var seen = new HashSet<string>();
        for(int i=0; i < strs.Length; i++){
            if(!seen.Contains(strs[i])){
                var list = new List<string>();
                list.Add(strs[i]);
                for(int j=i+1;j < strs.Length; j++){
                    if(IsSameAnagram(strs[i], strs[j])){
                        list.Add(strs[j]);
                        seen.Add(strs[j]);
                    }
                }
                res.Add(list);
            }
        }
        return res;
    }

    private bool IsSameAnagram(string str1, string str2){
        if(str1.Length != str2.Length) return false;
        var arr1 = str1.ToCharArray();
        var arr2 = str2.ToCharArray();
        Array.Sort(arr1);
        Array.Sort(arr2);
        int left = 0;
        while(left < arr1.Length){
            if(arr1[left] != arr2[left]) return false;
            left++;
        }
        return true;
    }
}