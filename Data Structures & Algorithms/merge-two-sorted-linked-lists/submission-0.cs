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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode head = new ListNode();
        ListNode node = head;

        while(list1 != null && list2 != null)
        {
            if(list1.val < list2.val)
            {
                node.next = new ListNode(list1.val);
                list1 = list1.next;
            }
            else
            {
                node.next = new ListNode(list2.val);
                list2 = list2.next;
            }
            node = node.next;
        }

        if(list1 != null)
        {
            node.next = list1;
        }
        if(list2 != null)
        {
            node.next = list2;
        }
        return head.next;
    }
}