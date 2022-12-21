//
public class Solution {
    public int NumIslands(char[][] grid) {
        int islandsCount = 0;
        for(int r=0; r < grid.Length; r++){
            for(int c=0; c < grid[0].Length; c++){
                if(grid[r][c] == '1'){
                    dfs(grid, r, c);
                    islandsCount++;
                }
            }
        }
        return islandsCount;
    }

    public void dfs(char[][] grid, int r, int c) {
        if(r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length) return;
        if(grid[r][c] == '0') return;
        grid[r][c] = '0';
        dfs(grid, r-1, c);
        dfs(grid, r, c+1);
        dfs(grid, r+1, c);
        dfs(grid, r, c-1);
    }
}