// 658. Find K Closest Elements
// https://leetcode.com/problems/find-k-closest-elements/description/
// Two pointers

public class Solution {
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        int left = 0;
        int right = arr.Length-1;
        while(right-left+1 > k){
            if(x - arr[left] > arr[right] - x)
                left++;
            else
                right--;
        }
        return arr[left..(right+1)].ToList();
    }
}