public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> hashMap = new();

        char[] chars;
        string sortedString = string.Empty;
        for(int i=0; i<strs.Length; i++)
        {
            chars = strs[i].ToCharArray();
            Array.Sort(chars);
            sortedString = new String(chars);

            hashMap.TryAdd(sortedString, new List<string>());
            hashMap[sortedString].Add(strs[i]);
        }
        return hashMap.Values.ToList();
    }
}
