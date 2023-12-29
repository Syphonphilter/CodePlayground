namespace C_Sharp_Playground.Code
{
    public class GetInterseciton
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null) return null;
            int numsA = getCounter(headA);
            int numsB = getCounter(headB);

            while (numsA > numsB)
            {
                headA = headA.next;
                numsA--;
            }
            while (numsB > numsA)
            {
                headB = headB.next;
                numsB--;
            }

            while (headA != headB)
            {
                headA = headA.next;
                headB = headB.next;
            }
            return headA;
            int getCounter(ListNode node)
            {
                int count = 0;
                while (node != null)
                {
                    if (node != null)
                    {

                        count++;
                        node = node.next;
                    }

                }
                return count;

            }
        }
    }
}