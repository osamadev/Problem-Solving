// 645. Set Mismatch
// https://leetcode.com/problems/set-mismatch/description/

public class Solution {
    public int[] FindErrorNums(int[] nums) {
        var seen = new Dictionary<int, int>();
        int missing = 0, duplicate = 0;
        Array.Sort(nums);
        for(int i=0; i < nums.Length; i++){
            if(seen.ContainsKey(nums[i])) seen[nums[i]] += 1;
            else seen[nums[i]] = 1;
        }
        for(int i=0; i < nums.Length; i++){
            if(!seen.ContainsKey(i+1)) {
                missing = i+1;
                continue;
            }
            if(seen[nums[i]] > 1) duplicate = nums[i];
        }
        return new int[] {duplicate, missing};
    }
}