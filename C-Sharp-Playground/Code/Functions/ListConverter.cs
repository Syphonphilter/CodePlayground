namespace C_Sharp_Playground.Code.Functions
{
    public class ListConverter
    {
        public ListNode ConvertToLinkedList(List<int> list)
        {
            ListNode final = new ListNode(-1);
            ListNode current = final;
            foreach (int num in list)
            {
                current.next = new ListNode(num);
                current = current.next;
            }
            return final.next;
        }
    }
}