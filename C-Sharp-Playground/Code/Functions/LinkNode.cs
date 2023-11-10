public class ListNode
{
    public int data;
    public ListNode next;
    public ListNode(int data = 0, ListNode next = null)
    {
        this.next = next;
        this.data = data;
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