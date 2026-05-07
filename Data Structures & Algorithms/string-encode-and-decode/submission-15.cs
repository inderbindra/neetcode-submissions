public class Solution 
{
    const int key = 2;
    const string separator = "@#@";
    public string Encode(IList<string> strs) {
        StringBuilder s = new();
        int asciiChar;

        if(strs.Count == 0)
        {
            return null;
        }

        for(int i=0; i<strs.Count; i++)
        {
            for(int j=0; j<strs[i].Length; j++)
            {   
                asciiChar = (int)strs[i][j] + key;
                //Console.WriteLine((char)asciiChar);
                s.Append((char)asciiChar);
            }
            s.Append(separator);
        }
        s.Remove(s.Length - separator.Length, separator.Length);
        Console.WriteLine(s.ToString());
        return s.ToString();
    }

    public List<string> Decode(string s) {

        List<string> decodedStr = new List<string>();
        if(s == null)
        {
            //Console.WriteLine("Hello");
            return decodedStr;
        }
        string[] strs = s.Split(separator);
        
        //Console.WriteLine("HelloBye");
        StringBuilder sb = new();
        int asciiChar;

        for(int i=0; i<strs.Length; i++)
        {
            for(int j=0; j<strs[i].Length; j++)
            {
                asciiChar = (int)strs[i][j] - key;
                //Console.WriteLine((char)asciiChar);
                sb.Append((char)asciiChar);
            }
            decodedStr.Add(sb.ToString());
            sb.Clear();
        }
        return decodedStr;
   }
}
