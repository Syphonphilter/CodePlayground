namespace C_Sharp_Playground.Code.Functions
{
    public class CustomLinkedList
    {
        public Node head;
        public Node tail;
        public int length;
        CustomLinkedList(dynamic value)
        {
            Node listNode = new Node(value);
            this.head = listNode;
            this.tail = head;
            this.length = 1;
        }
    }
}