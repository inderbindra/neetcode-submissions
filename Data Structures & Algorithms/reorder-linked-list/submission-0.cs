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
    public void ReorderList(ListNode head) {
        ListNode slow = new ListNode(0, head);
        ListNode fast = slow;
        ListNode firstList = head;

        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode secondList = slow.next;
        slow.next = null;

        secondList = ReverseList(secondList);

        ListNode firstNext = null, secondNext=null;
        
        while(secondList != null)
        {
            firstNext = firstList.next;
            secondNext = secondList.next;
            firstList.next = secondList;
            secondList.next = firstNext;
            firstList = firstNext;
            secondList = secondNext;
        }
    }

    private ListNode ReverseList(ListNode head)
    {
        ListNode curr = head;
        ListNode prev=null, node=null;
        while(curr != null)
        {
            node = curr.next;
            curr.next = prev;
            prev = curr;
            curr = node;
        }
        return prev;
    }
}