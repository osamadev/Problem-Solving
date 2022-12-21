public class Solution {
    public int Fib(int n) {
        if(n <= 1) return n;
        int x = 0;
        int y = 1, c = 0;
        int count = 2;
        while(count <= n){
            c = x+y;
            x = y;
            y = c;
            count++;
        }
        return c;
    }
}