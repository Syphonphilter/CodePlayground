using System.Diagnostics.Metrics;

public class ListNode
{
    public int data;
    public int  length ;
    public ListNode next;
    public ListNode(int data = 0, ListNode next = null,int Length = 0)
    {
        this.next = next;
        this.data = data;
        this.length = 0 ;
       
    }
}

public class Node
{

    public dynamic value;
    public Node next;
    public Node(dynamic value)
    {
        this.value = value;
        this.next = null;
    }
}