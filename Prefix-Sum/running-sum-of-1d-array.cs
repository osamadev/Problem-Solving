// 1480. Running Sum of 1d Array
// https://leetcode.com/problems/running-sum-of-1d-array/description/

public class Solution {
    public int[] RunningSum(int[] nums) {
        int[] movingSums = new int[nums.Length];
        movingSums[0] = nums[0];
        for(int i=1; i < nums.Length; i++)
            movingSums[i] = movingSums[i-1] + nums[i]; 
        return movingSums;
    }
}