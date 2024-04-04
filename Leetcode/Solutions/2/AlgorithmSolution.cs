namespace Leetcode.Solutions._2
{
	internal class AlgorithmSolution : Solution
	{
		public override ListNode AddTwoNumbers(ListNode l1, ListNode l2)
		{
			int x, y;
			int sum = l1.val + l2.val;
			ListNode result = new(sum % 10);
			int carry = sum / 10;

			ListNode? l1Head = l1.next; // Faster - Without conversion.
			ListNode? l2Head = l2.next;
			ListNode resultHead = result;

			while (l1Head != null || l2Head != null || carry != 0)
			{
				x = l1Head != null ? l1Head.val : 0;
				y = l2Head != null ? l2Head.val : 0;
				sum = x + y + carry;
				carry = sum / 10;

				resultHead.next = new ListNode(sum % 10);

				resultHead = resultHead.next;
				l1Head = l1Head?.next;
				l2Head = l2Head?.next;
			}

			return result;
		}

		// Slower
		public ListNode AddTwoNumbersSlower(ListNode l1, ListNode l2)
		{
			int x, y;
			int sum = l1.val + l2.val;
			ListNode result = new(sum % 10);
			int carry = sum / 10;

			ListNode resultHead = result;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
			l1 = l1.next; // Slower - Converting null literal or possible null value to non-nullable type.
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
			l2 = l2.next;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

			while (l1 != null || l2 != null || carry != 0)
			{
				x = l1 != null ? l1.val : 0;
				y = l2 != null ? l2.val : 0;
				sum = x + y + carry;
				carry = sum / 10;

				resultHead.next = new ListNode(sum % 10);

				resultHead = resultHead.next;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
				l1 = l1?.next;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
				l2 = l2?.next;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
			}

			return result;
		}
	}
}
