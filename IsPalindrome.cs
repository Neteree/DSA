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
    public bool IsPalindrome(ListNode head) {
        ListNode slowPtr = head;
        ListNode fastPtr = head;
        ListNode tail = null;

        while(fastPtr != null && fastPtr.next != null) {
            slowPtr = slowPtr.next;
            fastPtr = fastPtr.next.next;
        }

        while(slowPtr != null) {
            ListNode next = slowPtr.next;
            slowPtr.next = tail;
            tail = slowPtr;
            slowPtr = next;
        }

        while(tail != null) {
            if(head.val != tail.val) {
                return false;
            }

            head = head.next;
            tail = tail.next;
        }

        return true;
    }
}
