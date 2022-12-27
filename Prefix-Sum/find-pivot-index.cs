// 724. Find Pivot Index
// https://leetcode.com/problems/find-pivot-index/description/

public class Solution {
    public int PivotIndex(int[] nums) {
        int[] prefixSums = new int[nums.Length];
        prefixSums[0] = nums[0];
        for(int i=1; i < nums.Length; i++)
            prefixSums[i] = prefixSums[i-1] + nums[i];
        for(int i=0; i < nums.Length; i++){
            if(i > 0 && prefixSums[nums.Length-1] - prefixSums[i] == prefixSums[i-1])
                return i;
            if(i == 0 && prefixSums[nums.Length-1] - prefixSums[i] == 0)
                return i;
        }
        return -1;
    }
}