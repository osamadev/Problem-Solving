// 38. Count and Say
// https://leetcode.com/problems/count-and-say/description/

public class Solution {
    public string CountAndSay(int n) {
        string res = "1";
        for(int i=2; i <= n; i++){
            int len = 0;
            var sb = new StringBuilder();
            char prev = res[0];
            int counter = 0;
            while(len < res.Length){
                if(prev == res[len]){
                    counter++;
                }
                else{
                    sb.Append(counter.ToString());
                    sb.Append(prev.ToString());
                    counter = 1;
                    prev = res[len];
                }
                len++;
            }
            sb.Append(counter.ToString());
            sb.Append(prev.ToString());
            res = sb.ToString();
        }
        return res;
    }
}