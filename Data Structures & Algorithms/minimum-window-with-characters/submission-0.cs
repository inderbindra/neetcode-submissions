public class Solution {
    public string MinWindow(string s, string t) {
        if(s.Length < t.Length)
        {
            return "";
        }

        Dictionary<char, int> tMap = new();
        Dictionary<char, int> sMap = new();
        int left=0, right=0, need=0, have=0;
        string subStr=string.Empty, minStr=string.Empty;

        for(int i=0; i<t.Length; i++)
        {
            tMap.TryAdd(t[i], 0);
            tMap[t[i]] += 1;
            need++;
        }

        while(right < s.Length)
        {
            if(tMap.ContainsKey(s[right]))
            {
                sMap.TryAdd(s[right], 0);
                sMap[s[right]] += 1;

                if(tMap[s[right]] >= sMap[s[right]])
                {
                    have++;
                }
            }
            while(need == have && left <= right)
            {
                if(tMap.ContainsKey(s[left]))
                {
                    sMap[s[left]] -= 1;
                    if(tMap[s[left]] > sMap[s[left]])
                    {
                        have--;
                    }
                    if(sMap[s[left]] == 0)
                    {
                        sMap.Remove(s[left]);
                    }
                }
                subStr = s.Substring(left, right-left+1);
                if(need != have && 
                   (string.IsNullOrEmpty(minStr) ||
                   minStr.Length > subStr.Length))
                {
                    minStr = subStr;
                }
                left++;
            }
            right++;
        }
        return minStr;
    }
}
