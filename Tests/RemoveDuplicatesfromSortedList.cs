namespace Csharp.Tests
{
    public class RemoveDuplicatesfromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode ptr = head;
            while (ptr != null)
            {
                if (ptr.next != null)
                {
                    if (ptr.val == ptr.next.val)
                        ptr.next = ptr.next.next;
                    else
                    {
                        ptr = ptr.next;
                    }
                }
                else
                    break;
            }
            return head;
        }
    }


}