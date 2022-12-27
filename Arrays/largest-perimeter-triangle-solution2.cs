// 976. Largest Perimeter Triangle
// https://leetcode.com/problems/largest-perimeter-triangle/description/

public class Solution {
    public int LargestPerimeter(int[] nums) {
        int largestPerimeter = 0;
        Array.Sort(nums);
        for(int i=0; i < nums.Length-2; i++){
            int[] arr = new int[] {nums[i], nums[i+1], nums[i+2]};
            if(canFormTriangle(arr))
                largestPerimeter = Math.Max(largestPerimeter, nums[i]+nums[i+1]+nums[i+2]);
        }
        return largestPerimeter;
    }

    public bool canFormTriangle(int[] nums){
        return nums[0] < (nums[1] + nums[2]) && 
               nums[1] < (nums[0] + nums[2]) && 
               nums[2] < (nums[0] + nums[1]);
    }
}