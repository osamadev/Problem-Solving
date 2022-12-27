// 724. Find Pivot Index
// https://leetcode.com/problems/find-pivot-index/description/

public class Solution {
    public int PivotIndex(int[] nums) {
        int right = 0, left = 0;
        for(int i=0; i < nums.Length; i++) 
            right += nums[i];
        for(int i=0; i < nums.Length; i++){
            if(left == right-nums[i]) return i;
            left += nums[i];
            right -= nums[i];
        }
           
        return -1;
    }
}