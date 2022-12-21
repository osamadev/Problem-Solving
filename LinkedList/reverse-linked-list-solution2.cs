// 206. Reverse Linked List
// https://leetcode.com/problems/reverse-linked-list/description/

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
    public ListNode ReverseList(ListNode head) {
        if(head == null || head.next == null)
            return head;
         ListNode currNode = head;
         var nodesStack = new Stack<ListNode>();
         while(currNode.next != null)
         {
             nodesStack.Push(currNode);
             currNode = currNode.next;
         }
         head = currNode;
         while(nodesStack.Count != 0)
         {
             currNode.next = nodesStack.Pop();
             currNode = currNode.next;
         }
         currNode.next = null;
         return head;
     }
     /*public ListNode ReverseList(ListNode head) {
        if(head == null || head.next == null)
            return head;
         ListNode prev = null;
         ListNode curr = head;
         while(curr != null)
         {
             ListNode nextTemp = curr.next;
             curr.next  = prev;
             prev = curr;
             curr = nextTemp;
         }
         return prev;
     }*/
}