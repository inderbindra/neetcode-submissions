public class Solution {
    public bool IsValid(string s) {
        Stack<char> stk = new();
        Dictionary<char, char> hashMap = new()
        {
            {'}','{'},
            {']','['},
            {')','('}
        };

        for(int i=0; i<s.Length; i++)
        {
            if(hashMap.ContainsKey(s[i]) && stk.Count > 0 && stk.Peek() == hashMap[s[i]])
            {
                stk.Pop();
                continue;
            }
            stk.Push(s[i]);
        }
        return stk.Count > 0 ? false : true;
    }
}
