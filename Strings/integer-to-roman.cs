// 12. Integer to Roman
// https://leetcode.com/problems/integer-to-roman/description/

public class Solution {
    public string IntToRoman(int num) {
        int[] values = new int[] {1000,900,500,400,100,90,50,40,10,9,5,4,1};
        string[] strs = new string[] {"M","CM","D","CD","C","XC","L","XL","X","IX","V","IV","I"};
    
        StringBuilder sb = new StringBuilder();
        for(int i=0;i<values.Length && num > 0;i++) {
            while(num >= values[i]) {
                num -= values[i];
                sb.Append(strs[i].ToString());
            }
        }
        return sb.ToString();
    }
}