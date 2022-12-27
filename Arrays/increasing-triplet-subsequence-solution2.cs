// 334. Increasing Triplet Subsequence
// https://leetcode.com/problems/increasing-triplet-subsequence/description/

public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        int first = int.MaxValue, second = int.MaxValue;
        int firstIdx=0, secondIdx=0;
        for(int i=0; i < nums.Length;i++){
            if(i > secondIdx && nums[i] > second && first < second) return true;
            if(first > nums[i]){
                first = Math.Min(first, nums[i]);
                firstIdx = i; 
            }
            else if(i > firstIdx && i < nums.Length-1 && nums[i] > first){
                second = Math.Min(second, nums[i]);
                secondIdx = i;
            }          
        }
        return false;
    }
}