public class MergeList
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

    public ListNode MergeTwoSortedList(ListNode list1, ListNode list2)
    {
        ListNode final = new ListNode(-1);
        ListNode current = final;
        while (list1 != null && list2 != null)
        {
            if (list1.data <= list2.data)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }
        if (list1 == null && list2 != null)
        {
            current.next = list2;
        }
        if (list2 == null && list1 != null)
        {
            current.next = list1;
        }
        return final.next;
    }
}