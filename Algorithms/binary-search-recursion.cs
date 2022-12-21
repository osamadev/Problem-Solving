// 704. Binary Search
// https://leetcode.com/problems/binary-search/description/
public class Solution {
    public int Search(int[] nums, int target) {
        return Search(nums, target, 0, nums.Length-1);
    }

    public int Search(int[] nums, int target, int low, int hi) {
        if(low > hi) return -1;
        int mid = low + (hi - low) / 2;
        if(nums[mid] == target) return mid;
        if(nums[mid] > target) return Search(nums, target, low, mid-1);
        else return Search(nums, target, mid+1, hi);
    }
}
