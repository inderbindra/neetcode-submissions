public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder sb = new();

        for(int i=0; i<s.Length; i++)
        {
            if(char.IsLetterOrDigit(s[i]))
            {
                sb.Append(char.ToLower(s[i]));
            }
        }

        int left =0, right = sb.Length-1;
        while(left < right)
        {
            if(sb[left] != sb[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
