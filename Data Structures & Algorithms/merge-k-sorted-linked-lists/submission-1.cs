/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {    
    public ListNode MergeKLists(ListNode[] lists) {
        ListNode node = null;

        if(lists != null && lists.Length > 0)
        {
            node = lists[0];
            for(int i=1; i<lists.Length; i++)
            {
                node = MergeSortedList(node, lists[i]);
            }
        }
        return node;
    }
    private ListNode MergeSortedList(ListNode n1, ListNode n2)
    {
        ListNode node = new ListNode(0);
        ListNode head = node;

        while(n1 != null && n2 != null)
        {
            if(n1.val < n2.val)
            {
                node.next = new ListNode(n1.val);
                n1 = n1.next;
            }
            else
            {
                node.next = new ListNode(n2.val);
                n2 = n2.next;
            }
            node = node.next;
        }
        if(n1 != null)
        {
            node.next = n1;
        }        
        if(n2 != null)
        {
            node.next = n2;
        }
        return head.next;
    }
}
