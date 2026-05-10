public class Solution {
    public int CharacterReplacement(string s, int k) {
        int left=0, right=0, len=0, maxLen=0, maxFreq=0;
        Dictionary<char, int> charFreq = new();

        while(right < s.Length)
        {
            charFreq.TryAdd(s[right], 0);
            charFreq[s[right]] += 1;
            maxFreq = Math.Max(maxFreq, charFreq[s[right]]);
            len = right - left + 1;

            if(len - maxFreq > k)
            {
                charFreq[s[left]] -= 1;
                left++;
                maxFreq = charFreq.Values.Max();
            }
            len = right - left + 1;
            maxLen= Math.Max(maxLen, len);
            right++;
        }
        return maxLen;
    }
}
