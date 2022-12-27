// 766. Toeplitz Matrix
// https://leetcode.com/problems/toeplitz-matrix/description/

public class Solution {
    public bool IsToeplitzMatrix(int[][] matrix) {
        for(int c=0; c < matrix[0].Length; c++){
            var startingItem = matrix[0][c];
            int r = 1, col=c+1;
            while(IsInBound(matrix, r, col))
                if(startingItem != matrix[r++][col++]) return false;
        }

        for(int r=1; r < matrix.Length; r++){
            var startingItem = matrix[r][0];
            int c=1, row = r+1;
            while(IsInBound(matrix, row, c))
                if(startingItem != matrix[row++][c++]) return false;
        }
        return true;
    }

    private bool IsInBound(int[][] matrix, int r, int c){
        if(r < 0 || r >= matrix.Length || c <0 || c >= matrix[0].Length) return false;
        return true;
    }
}