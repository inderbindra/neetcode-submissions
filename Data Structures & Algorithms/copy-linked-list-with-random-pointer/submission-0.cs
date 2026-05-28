/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        Dictionary<Node, Node> hashMap = new();
        Node node = head;
        while(node != null)
        {
            hashMap.TryAdd(node, new Node(node.val));
            node = node.next;
        }

        node = head;
        Node newNode = null;
        while(node != null)
        {
            newNode = hashMap[node];
            if(node.next != null)
            {
                newNode.next = hashMap[node.next];
            }
            if(node.random != null)
            {
                newNode.random = hashMap[node.random];
            }
            node = node.next;
        }
        return hashMap.Count > 0 ? hashMap[head] : null;
    }
}
