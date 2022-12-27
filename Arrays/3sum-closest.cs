// 16. 3Sum Closest
// https://leetcode.com/problems/3sum-closest/description/
// Two pointers

public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        int minDistance = int.MaxValue;
        int closestSum = int.MinValue;
        for(int i=0; i < nums.Length; i++){
            int left=i+1;
            int right = nums.Length-1;
            while(left < right){
                int sum = nums[i] + nums[left] + nums[right];
                if(target == sum) return sum;
                int distance = Math.Abs(sum - target);
                if(distance < minDistance){
                    closestSum = sum;
                    minDistance = Math.Min(minDistance, distance);
                }
                if(sum > target)
                    right--;
                else
                    left++;
            }
        }
        return closestSum;
    }
}
