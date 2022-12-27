// 976. Largest Perimeter Triangle
// https://leetcode.com/problems/largest-perimeter-triangle/description/

public class Solution {
    public int LargestPerimeter(int[] nums) {
        Array.Sort(nums);
        for(int i=nums.Length-1; i > 1; i--){
            int[] arr = new int[] {nums[i], nums[i-1], nums[i-2]};
            if(nums[i] < nums[i-1] + nums[i-2])
                return nums[i]+nums[i-1]+nums[i-2];
        }
        return 0;
    }
}