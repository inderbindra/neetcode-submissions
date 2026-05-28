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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int sum=0, carry=0, digit=0;
        int l1Val=0, l2Val = 0;
        ListNode node = new ListNode(0, null);
        ListNode head = node;
        while(l1 != null || l2 != null || carry > 0)
        {
            l1Val = (l1 == null) ? 0 : l1.val;
            l2Val = (l2 == null) ? 0 : l2.val;

            sum = l1Val + l2Val + carry;
            digit = sum % 10;
            carry = sum / 10;

            node.next = new ListNode(digit, null);
            node = node.next;

            l1 = (l1 == null)? null : l1.next;
            l2 = (l2 == null)? null : l2.next;
        }
        return head.next;
    }
}
