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
     public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if(list1 == null && list2 == null) return null;
        ListNode root = new ListNode();
        ListNode current = root;
        while(list1 != null || list2 != null){
            if(list1 == null) {
                current.next = list2;
                break;
            }
            if(list2 == null) {
                current.next = list1;
                break;
            }
            if(list1.val > list2.val){
                current.next = list2;
                list2 = list2.next;
            }
            else if(list1.val < list2.val){
                current.next = list1;
                list1 = list1.next;
            }
            else{
                current.next = list1;
                list1 = list1.next;
                current = current.next;
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }
        return root.next;
     }
    
}