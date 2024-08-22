public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode dummy = null;

        while(head != null) {
            ListNode next = head.next;
            head.next = dummy;
            dummy = head;
            head = next;
        }
      
        return dummy;
    }
}
