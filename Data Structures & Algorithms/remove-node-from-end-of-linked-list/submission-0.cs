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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode slow = new ListNode(0, head);
        ListNode fast = head;
        ListNode node = slow; // This is added if the list has 1 element, then if return head, then it will be wrong o/p.

        while(n > 0 && fast != null)
        {
            fast = fast.next;
            n--;
        }
        while(fast != null)
        {
            slow = slow.next;
            fast = fast.next;
        }
        slow.next = slow.next.next;
        return node.next;
    }
}
