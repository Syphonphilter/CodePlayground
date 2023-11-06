using System.Runtime.InteropServices.ComTypes;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using C_Sharp_Playground.Code;
using Playground.Code;
using Xunit.Sdk;
using System.Numerics;
using C_Sharp_Playground.Code.Functions;

class Program
{


    static void Main()
    {
        List<int> lists = new List<int>();
        lists.Add(1);
        lists.Add(2);
        lists.Add(2);
        lists.Add(2);
        lists.Add(4);
        lists.Add(4);
        ListConverter listConverter = new ListConverter();
        ListNode test = listConverter.ConvertToLinkedList(lists);

        Console.WriteLine(DeleteDuplicates(test));

    }
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
