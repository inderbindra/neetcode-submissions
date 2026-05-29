public class LRUCache {
    LinkedList<(int key, int val)> nodes;
    Dictionary<int, LinkedListNode<(int key, int val)>> nodesMap;
    readonly int maxCapacity;
    public LRUCache(int capacity) {
        this.maxCapacity = capacity;
        this.nodes = new();
        this.nodesMap = new();
    }
    
    public int Get(int key) 
    {
        LinkedListNode<(int key, int val)> node = null;
        if(nodesMap.ContainsKey(key))
        {
            node = nodesMap[key];
            nodes.Remove(node);
            nodes.AddLast(node);
            return node.Value.val;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        LinkedListNode<(int key, int val)> node = new LinkedListNode<(int, int)>((key, value));
        if(nodesMap.ContainsKey(key))
        {
            var item = nodesMap[key];
            nodes.Remove(item);
            nodesMap[key] = node;
            nodes.AddLast(node);
        }
        else
        {
            if(maxCapacity == nodes.Count)
            {
                var item = nodes.First;
                nodesMap.Remove(item.Value.key);
                nodes.RemoveFirst();
            }
            nodes.AddLast(node);
            nodesMap.TryAdd(node.Value.key, node);
        }
                
    }
}
