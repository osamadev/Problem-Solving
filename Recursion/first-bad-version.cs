// 278. First Bad Version
// https://leetcode.com/problems/first-bad-version/description/

/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        return FirstBadVersion(1, n);
    }

    public int FirstBadVersion(int low, int hi) {
        int mid = low + (hi - low) / 2;
        if(low > hi) return mid;
        if(IsBadVersion(mid)){
            return FirstBadVersion(low, mid-1);
        }
        else
            return FirstBadVersion(mid+1, hi);
    }
}