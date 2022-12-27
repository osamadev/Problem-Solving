// 523. Continuous Subarray Sum
// https://leetcode.com/problems/continuous-subarray-sum/description/
public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        int[] prefixSum = new int[nums.Length];
        Dictionary<int, int> dict = new Dictionary<int, int>();
        dict.Add(0, -1);
        for(int i=0; i < nums.Length; i++){
            if(i > 0) prefixSum[i] = nums[i] + prefixSum[i-1]; 
            else prefixSum[i] = nums[i];
            prefixSum[i] %= k; 
            if(dict.TryGetValue(prefixSum[i], out int j)){
                if(i - j > 1) return true;
            }
            else
                dict.Add(prefixSum[i], i);
        }
        return false;
    }
}