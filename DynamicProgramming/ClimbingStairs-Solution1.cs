public class Solution {
    public int ClimbStairs(int n) {
        if(n < 2) return n;
        int a = 0;
        int b = 1;
        int c = 2;
        for(int i=3; i < n+1; i++)
        {
            a = b;
            b = c;
            c = a + b;
        }
        return c;
    }
}