public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> hashSet = new();
        int left=0, right=0, longestSubstr=0, maxSubstr=0;

        while(right < s.Length)
        {
            while(hashSet.Contains(s[right]))
            {
                hashSet.Remove(s[left]);
                left++;
            }
            hashSet.Add(s[right]);
            longestSubstr = hashSet.Count;
            maxSubstr = Math.Max(maxSubstr, longestSubstr);
            right++;
        }
        return maxSubstr;
    }
}
