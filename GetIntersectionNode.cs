/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        ListNode lA = headA;
        ListNode lB = headB;

        while(lA != lB) {
            lA = lA != null ? lA.next : headB;
            lB = lB != null ? lB.next: headA;
        }

        return lA;
    }
}
