// 733. Flood Fill
// https://leetcode.com/problems/flood-fill/description/

public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        int currColor = image[sr][sc];
        return dfs(image, sr, sc, color, currColor);
    }

    public int[][] dfs(int[][] image, int r, int c, int newColor, int originalColor){
        if(r >= image.Length || r < 0 || c < 0 || c >= image[0].Length) return image;
        if(originalColor == newColor) return image;
        if(image[r][c] != originalColor) return image;
        image[r][c] = newColor;
        dfs(image, r-1, c, newColor, originalColor);
        dfs(image, r, c+1, newColor, originalColor);
        dfs(image, r+1, c, newColor, originalColor);
        dfs(image, r, c-1, newColor, originalColor);
        return image;
    }
}