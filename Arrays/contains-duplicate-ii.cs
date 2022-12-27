// 219. Contains Duplicate II
// https://leetcode.com/problems/contains-duplicate-ii/description/

public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        for(int i=0; i  < nums.Length; i++){
            if(dict.ContainsKey(nums[i]))
                if(i - dict[nums[i]] <= k) return true;
            dict[nums[i]] = i;
        }
        return false;
    }
}