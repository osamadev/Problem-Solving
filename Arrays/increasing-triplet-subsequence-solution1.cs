// 334. Increasing Triplet Subsequence
// https://leetcode.com/problems/increasing-triplet-subsequence/description/

public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        int first = int.MaxValue, second = int.MaxValue;
        for(int i=0; i < nums.Length;i++){
            if(first >= nums[i]){
                first = nums[i];
            }
            else if(second >= nums[i]){
                second = nums[i];
            }
            else
                return true;          
        }
        return false;
    }
}