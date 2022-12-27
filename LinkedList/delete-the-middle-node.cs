// 2095. Delete the Middle Node of a Linked List
// https://leetcode.com/problems/delete-the-middle-node-of-a-linked-list/description/

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
    public ListNode DeleteMiddle(ListNode head) {
        if(head == null || head.next == null) return null;
        var currNode = head;
        int n = 0;
        while(currNode != null){
            n++;
            currNode = currNode.next;
        }
        int deleteIdx = n / 2;
        currNode = head;
        int currIdx = 0;
        ListNode prevNode= null;
         while(currNode != null){
             if(currIdx == deleteIdx){
                prevNode.next = currNode.next;
                break;
             }
             prevNode = currNode;
             currNode = currNode.next;
             currIdx++;
         }
         return head;
    }
}

