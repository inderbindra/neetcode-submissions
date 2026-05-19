public class TimeMap {
    Dictionary<string, List<(int timestamp, string value)>> TimeMapKV;
    public TimeMap() {
        TimeMapKV = new();
    }
    
    public void Set(string key, string value, int timestamp) {
        TimeMapKV.TryAdd(key, new List<(int timestamp, string value)>());
        TimeMapKV[key].Add((timestamp, value));
    }
    
    public string Get(string key, int timestamp) {
        string prev="";
        if(TimeMapKV.ContainsKey(key))
        {
            var data = TimeMapKV[key];
            int left=0, right=data.Count-1, mid=0;

            while(left <= right)
            {
                mid = (left + right)/2;
                if(timestamp >= data[mid].timestamp)
                {
                    prev = data[mid].value;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }
        return prev;
    }
}
