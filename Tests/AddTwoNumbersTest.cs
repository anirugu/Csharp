namespace Csharp.Tests
{
    public class AddTwoNumbersTest
    {
        [Fact]
        public void Test()
        {
            AddTwoNumbers(
                new ListNode(2, new ListNode(4, new ListNode(3))), 
                new ListNode(5, new ListNode(6, new ListNode(4))));
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            /// WIP, need to fix reference
            ListNode result = null;
            int carry = 0;
            int total = 0;
            while (l1 != null && l2 != null)
            {
                total = l1.val + l2.val + carry;
                SetNode(result);
                l1 = l1.next;
                l2 = l2.next;
            }
            while (l1 != null)
            {
                total = l1.val + carry;
                l1 = l1.next;
            }
            while (l2 != null)
            {
                total = l2.val + carry;
                l2 = l2.next;
            }
            

            void SetNode(ListNode node)
            {
                if (result == null)
                {
                    result = new ListNode(total % 10);

                }
                else if(result.next == null)
                {
                    result.next = new ListNode(total % 10);
                }
                if (total > 9)
                    carry = 1;
                else
                    carry = 0;
            }
            return result;
        }
    }


}