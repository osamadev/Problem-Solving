// 704. Binary Search
// https://leetcode.com/problems/binary-search/description/
public class Solution {
    public int Search(int[] nums, int target) {
        int low=0, high=nums.Length-1;
        while(low <= high){
            int mid = (low + high) / 2;
            if(nums[mid] > target)
                high = mid-1;
            else if(nums[mid] < target)
                low = mid+1;
            else
                return mid;
        }
        return -1;
    }
}
