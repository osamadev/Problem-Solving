// 1328. Break a Palindrome
// https://leetcode.com/problems/break-a-palindrome/description/

public class Solution {
    public string BreakPalindrome(string palindrome) {
        int idx = -1;
        int possibleValue = -1;
        for(int i=0; i < palindrome.Length; i++){
            if(((int)palindrome[i] - 'a') > 0){
                possibleValue = 'a';
                var sb = new StringBuilder(palindrome);
                    sb[i] = (char)(possibleValue);
                    if(!IsPalindrome(sb.ToString()))
                        return sb.ToString();
            }
        }

        for(int i=palindrome.Length-1; i > 0; i--){
            possibleValue = palindrome[i] - 'a' + 1;
            var sb = new StringBuilder(palindrome);
            sb[i] = (char)(possibleValue + 'a');
            if(!IsPalindrome(sb.ToString()))
                return sb.ToString();
        }
        return "";
    }

    private bool IsPalindrome(string str){
        int left=0, right=str.Length-1;
        while(left < right){
            if(str[left] != str[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
}

