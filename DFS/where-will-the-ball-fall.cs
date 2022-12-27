// 1706. Where Will the Ball Fall
// https://leetcode.com/problems/where-will-the-ball-fall/description/

public class Solution {
    public int[] FindBall(int[][] grid) {
        int[] res = new int[grid[0].Length];
        for(int c=0; c < grid[0].Length; c++)
            res[c] = dfs(grid, 0, c);
        return res;
    }

    private int dfs(int[][] grid, int r, int c){
        if(!IsInBound(grid, r, c)) return -1;
        if(r == grid.Length && (c >= 0 || c < grid[0].Length)) return c;
        if(grid[r][c] == 1 && c+1 < grid[0].Length && grid[r][c] != grid[r][c+1]) return -1;
        if(grid[r][c] == -1 && c-1 >= 0 && grid[r][c] != grid[r][c-1]) return -1;
        return dfs(grid, r+1, c + grid[r][c]);
    }

    private bool IsInBound(int[][] grid, int r, int c){
        if(c < 0 || c >= grid[0].Length) return false;
        return true;
    }
}