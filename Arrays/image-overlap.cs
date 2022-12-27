// 835. Image Overlap
// https://leetcode.com/problems/image-overlap/description/

public class Solution {
    public int LargestOverlap(int[][] img1, int[][] img2) {
        int maxOverlap = int.MinValue;
        int n = img1.Length;
        for(int r=-n+1; r < n; r++){
            for(int c=-n+1; c < n ; c++){
               maxOverlap = Math.Max(GetOnesCount(img1, img2, r, c), maxOverlap);
            }
        }
        return maxOverlap;
    }

    private int GetOnesCount(int[][] img1, int[][] img2, int rowOffset, int colOffset) {
        int onesCount = 0;
        int n = img1.Length;
        for(int r=0; r < n; r++){
            for(int c=0; c < n ; c++){
                if(IsInBound(n, r+rowOffset, c+colOffset) && img2[r][c] + img1[r+rowOffset][c+colOffset] == 2)
                    onesCount++;
            }
        }
        return onesCount;
    }

    private bool IsInBound(int n, int row, int col){
        if(row < 0 || row >= n || col < 0 || col >= n) return false;
        return true;
    }

}