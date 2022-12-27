// 1293. Shortest Path in a Grid with Obstacles Elimination
// https://leetcode.com/problems/shortest-path-in-a-grid-with-obstacles-elimination/description/

public class Solution {
    int[][] directions = new int[4][];
    public int ShortestPath(int[][] grid, int k) {
        if(grid.Length == 1 && grid[0].Length == 1) return 0;
        directions[0] = new int[]{0, 1}; // right
        directions[1] = new int[]{1, 0}; // down
        directions[2] = new int[]{0, -1}; // left
        directions[3] = new int[]{-1, 0}; // up

        return BFS(grid, 0, 0, 0, k);
    }

    private int BFS(int[][] grid, int row, int col, int distance, int rem){
        int[,] visited = new int[grid.Length, grid[0].Length];
        for(int i=0; i < visited.GetLength(0); i++){
            for(int j=0; j < visited.GetLength(1); j++){
                visited[i,j] = -1;
            }
        }
        var queue = new Queue<int[]>();
        queue.Enqueue(new int[]{row, col, distance, rem});
        while(queue.Count > 0){
            var curCell = queue.Dequeue();
            var x = curCell[0];
            var y = curCell[1];
            var dist = curCell[2];
            var k = curCell[3];
           
            if(x == grid.Length-1 && y == grid[0].Length-1) return dist;
            dist++;
            if(grid[x][y] == 1){
                if(k > 0) k--;
                else continue;
            }

            if(visited[x,y] != -1 && visited[x,y] >= k)
                continue;
            visited[x,y] = k;
            foreach(var dir in directions){
                int newX = x + dir[0];
                int newY = y + dir[1];
                if(isInBound(grid, newX, newY)){
                    if(grid[newX][newY] == 0 || (grid[newX][newY] == 1 && rem > 0))
                         queue.Enqueue(new int[]{newX, newY, dist, k});
                }
            }
        }
        return -1;
    }

    private bool isInBound(int[][] grid, int r, int c){
        if(r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length) return false;
        return true;
    }
}