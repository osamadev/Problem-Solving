// 1480. Running Sum of 1d Array
// https://leetcode.com/problems/running-sum-of-1d-array/description/

public class Solution {
    public int[] RunningSum(int[] nums) {
        int l=0, r=1;
        int[] sum = new int[nums.Length];
        sum[0] = nums[0];
        while(r < nums.Length){
            sum[r] = sum[r-1] + nums[r];
            r++;
        }
        return sum;
    }
}