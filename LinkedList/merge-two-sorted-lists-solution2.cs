// 21. Merge Two Sorted Lists
// https://leetcode.com/problems/merge-two-sorted-lists/description/

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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        if(l1 == null && l2 == null) return null;
        if(l1 == null) return l2;
        if(l2 == null) return l1;
        ListNode head = new ListNode(0);
        ListNode curr = head;
        while(l1 != null && l2 != null)
        {
            if(l1.val > l2.val)
            {
                curr.next = l2;
                l2 = l2.next;
            }
            else
            {
                curr.next = l1;
                l1 = l1.next;
            }
            
            curr = curr.next;
        }
        curr.next = l1??l2;
        return head.next;
    }
}