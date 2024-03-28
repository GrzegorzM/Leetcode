namespace Leetcode.Solutions._2
{
	internal class Solution
	{
		public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
		{
			return l1;
		}

		#region Param1
		public ListNode Param1_1 { get; set; } = new ListNode()
		{
			Value = 2,
			Next = new ListNode()
			{
				Value = 4,
				Next = new ListNode()
				{
					Value = 3,
					Next = null
				}
			}
		};

		public ListNode Param1_2 { get; set; } = new ListNode()
		{
			Value = 5,
			Next = new ListNode()
			{
				Value = 6,
				Next = new ListNode()
				{
					Value = 4,
					Next = null
				}
			}
		};
		#endregion

		#region Param2
		public ListNode Param2_1 { get; set; } = new ListNode()
		{
			Value = 0,
			Next = null
		};

		public ListNode Param2_2 { get; set; } = new ListNode()
		{
			Value = 0,
			Next = null
		};
		#endregion

		#region Param3
		public ListNode Param3_1 { get; set; } = new ListNode()
		{
			Value = 9,
			Next = new ListNode()
			{
				Value = 9,
				Next = new ListNode()
				{
					Value = 9,
					Next = new ListNode()
					{
						Value = 9,
						Next = new ListNode()
						{
							Value = 9,
							Next = new ListNode()
							{
								Value = 9,
								Next = new ListNode()
								{
									Value = 9,
									Next = null
								}
							}
						}
					}
				}
			}
		};

		public ListNode Param3_2 { get; set; } = new ListNode()
		{
			Value = 9,
			Next = new ListNode()
			{
				Value = 9,
				Next = new ListNode()
				{
					Value = 9,
					Next = new ListNode()
					{
						Value = 9,
						Next = null
					}
				}
			}
		};
		#endregion
	}


	//Definition for singly-linked list.
	public class ListNode
	{
		public ListNode(int val = 0, ListNode? next = null)
		{
			this.Value = val;
			this.Next = next;
		}

		public int Value { get; set; }

		public ListNode? Next { get; set; }
	}
}
