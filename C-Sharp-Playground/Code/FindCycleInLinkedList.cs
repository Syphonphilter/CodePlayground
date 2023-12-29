namespace C_Sharp_Playground.Code
{
    public class FindCycleInLinkedList
    {
        public bool HasCycle(ListNode head)
        {
            

            if (head != null)
            {
                ListNode hare = head;
            
                ListNode turtle = head;
                while (hare != null && hare.next != null)
                {
                    turtle = turtle.next;
                    hare = hare.next.next;
                    if (hare == turtle)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}