namespace C_Sharp_Playground.Code
{
    public class RemoveListDuplicates
    {
        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
            {
                return head;
            }
            ListNode final = new ListNode(head.data);
            ListNode current = final;
            while (head != null)
            {
                if (current.data == head.data)
                {
                    if (current.next == head && head.next == null)
                    {
                        current.next = null;
                        head = null;
                        break;
                    }
                    head = head.next;
                    current.next = null;
                }
                else
                {
                    current.next = head;
                    head = head.next;
                    current = current.next;
                }
            }
            return final;
        }

    }
}