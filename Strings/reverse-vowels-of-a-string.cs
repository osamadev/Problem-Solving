// 345. Reverse Vowels of a String
// https://leetcode.com/problems/reverse-vowels-of-a-string/description/

public class Solution {
    public string ReverseVowels(string s) {
        int l = 0, r=s.Length-1;
        var list = new List<char> {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
        var vowels = new HashSet<char>(list);
        var arr = s.ToCharArray();
        while(l < r){
            if(vowels.Contains(arr[l])){
                 if(vowels.Contains(arr[r])){
                    var temp = arr[l];
                    arr[l] = arr[r];
                    arr[r] = temp;
                    l++;
                    r--;
                }
                else
                    r--;
            }
            else{
                l++;
            }
        }
        return String.Join("", arr);
    }
}