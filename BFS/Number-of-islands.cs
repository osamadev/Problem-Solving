public class Solution {
    public int NumIslands(char[][] grid) {
        // traverse the matrix
        // if the current land "1" doesn't have any adjacent "1's", increment number of islands
        // else keep the number as it is
        int[][] directions = new int[4][];
        directions[0] = new int[] {-1, 0};
        directions[1] = new int[] {0, 1};
        directions[2] = new int[] {1, 0};
        directions[3] = new int[] {0, -1};
        
        int numOfIslands = 0;
        var queue = new Queue<(int, int)>();
        
        for(int rowIdx=0; rowIdx < grid.Length; rowIdx++){
            for(int colIdx=0; colIdx < grid[0].Length; colIdx++){
                if(grid[rowIdx][colIdx] == '1'){
                    grid[rowIdx][colIdx] = '0';
                    numOfIslands++;
                    queue.Enqueue((rowIdx, colIdx));
                    while(queue.Count != 0){
                        var (row, col) = queue.Dequeue();
                        for(int i=0; i < directions.Length; i++){
                            int newRow = directions[i][0] + row;
                            int newCol = directions[i][1] + col;
                            if(newRow >= 0 && newCol >= 0 && newRow < grid.Length 
                               && newCol < grid[0].Length && grid[newRow][newCol] == '1'){
                                    grid[newRow][newCol] = '0';
                                    queue.Enqueue((newRow, newCol));
                            }
                        }   
                    }
                }
            }
        }
        return numOfIslands;
    }
}