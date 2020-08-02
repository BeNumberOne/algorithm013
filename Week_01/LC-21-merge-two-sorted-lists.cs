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
    public ListNode MergeTwoLists(ListNode a1, ListNode b1) 
    {
        // pre -> l1 -> l2 
        var fakeHead = new ListNode();
        var pre = fakeHead;
        
        while( a1 != null && b1 != null)
        {         
            if(a1.val <= b1.val)
            {
                pre.next = a1;
                a1 = a1.next;
            }
            else
            {
                pre.next = b1;
                b1 = b1.next;
            }
            
            pre = pre.next;
        }

        if(a1 != null) pre.next = a1;
        if(b1 != null) pre.next = b1;

        return fakeHead.next;
    }
}