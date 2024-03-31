using System.Text;

namespace Leetcode.Solutions._2
{
	internal class Solution
	{
		private ListNode result;

		public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
		{
			string firstNumber = GetNumber(l1);
			string secondNumber = GetNumber(l2);
			int length = firstNumber.Length >= secondNumber.Length ? firstNumber.Length : secondNumber.Length;

			bool overflowed = false;
			StringBuilder sb = new StringBuilder();
			for (int i = 1; i <= length; i++)
			{
				int firstNumberNthColumn = 0;
				int secondNumberNthColumn = 0;

				if (firstNumber.Length >= i && secondNumber.Length >= i)
				{
					firstNumberNthColumn = Convert.ToInt16(firstNumber[firstNumber.Length - i].ToString());
					secondNumberNthColumn = Convert.ToInt16(secondNumber[secondNumber.Length - i].ToString());
				}
				else if (firstNumber.Length >= i)
				{
					firstNumberNthColumn = Convert.ToInt16(firstNumber[firstNumber.Length - i].ToString());
				}
				else if (secondNumber.Length >= i)
				{
					secondNumberNthColumn = Convert.ToInt16(secondNumber[secondNumber.Length - i].ToString());
				}

				int sumNumbersFromSameColumn = firstNumberNthColumn + secondNumberNthColumn;
				if (overflowed)
				{
					sumNumbersFromSameColumn += 1;
					overflowed = false;
				}

				if (sumNumbersFromSameColumn > 9)
				{
					overflowed = true;
					sumNumbersFromSameColumn -= 10;
				}
				sb.Append(sumNumbersFromSameColumn);
			}

			if (overflowed)
			{
				sb.Append(1);
			}
			string sum = new string(sb.ToString().Reverse().ToArray());

			return Result(sum.ToString());
		}

		private string GetNumber(ListNode l1)
		{
			string sum = string.Empty;

			if (l1.next == null)
			{
				return l1.val.ToString();
			}

			sum += $"{GetNumber(l1.next)}{l1.val}";

			return sum;
		}

		private ListNode Result(string number)
		{
			if (result == null)
			{
				result = new ListNode(Convert.ToInt16(number[0].ToString()));
			}
			else
			{
				result = new ListNode(Convert.ToInt16(number[0].ToString()), result);
			}

			if (!string.IsNullOrEmpty(number.Substring(1)))
			{
				Result(number.Substring(1));
			}

			return result;
		}

		#region Param1

		public ListNode Param1_1 { get; set; } = new ListNode()
		{
			val = 2,
			next = new ListNode()
			{
				val = 4,
				next = new ListNode()
				{
					val = 3,
					next = null
				}
			}
		};

		public ListNode Param1_2 { get; set; } = new ListNode()
		{
			val = 5,
			next = new ListNode()
			{
				val = 6,
				next = new ListNode()
				{
					val = 4,
					next = null
				}
			}
		};

		#endregion Param1

		#region Param2

		public ListNode Param2_1 { get; set; } = new ListNode()
		{
			val = 0,
			next = null
		};

		public ListNode Param2_2 { get; set; } = new ListNode()
		{
			val = 0,
			next = null
		};

		#endregion Param2

		#region Param3

		public ListNode Param3_1 { get; set; } = new ListNode()
		{
			val = 9,
			next = new ListNode()
			{
				val = 9,
				next = new ListNode()
				{
					val = 9,
					next = new ListNode()
					{
						val = 9,
						next = new ListNode()
						{
							val = 9,
							next = new ListNode()
							{
								val = 9,
								next = new ListNode()
								{
									val = 9,
									next = null
								}
							}
						}
					}
				}
			}
		};

		public ListNode Param3_2 { get; set; } = new ListNode()
		{
			val = 9,
			next = new ListNode()
			{
				val = 9,
				next = new ListNode()
				{
					val = 9,
					next = new ListNode()
					{
						val = 9,
						next = null
					}
				}
			}
		};

		#endregion Param3

		#region Param4

		public ListNode Param4_1 { get; set; } = new ListNode()
		{
			val = 1,
			next = new ListNode()
			{
				val = 0,
				next = new ListNode()
				{
					val = 0,
					next = new ListNode()
					{
						val = 0,
						next = new ListNode()
						{
							val = 0,
							next = new ListNode()
							{
								val = 0,
								next = new ListNode()
								{
									val = 0,
									next = new ListNode()
									{
										val = 0,
										next = new ListNode()
										{
											val = 0,
											next = new ListNode()
											{
												val = 0,
												next = new ListNode()
												{
													val = 0,
													next = new ListNode()
													{
														val = 0,
														next = new ListNode()
														{
															val = 0,
															next = new ListNode()
															{
																val = 0,
																next = new ListNode()
																{
																	val = 0,
																	next = new ListNode()
																	{
																		val = 0,
																		next = new ListNode()
																		{
																			val = 0,
																			next = new ListNode()
																			{
																				val = 0,
																				next = new ListNode()
																				{
																					val = 0,
																					next = new ListNode()
																					{
																						val = 0,
																						next = new ListNode()
																						{
																							val = 0,
																							next = new ListNode()
																							{
																								val = 0,
																								next = new ListNode()
																								{
																									val = 0,
																									next = new ListNode()
																									{
																										val = 0,
																										next = new ListNode()
																										{
																											val = 0,
																											next = new ListNode()
																											{
																												val = 0,
																												next = new ListNode()
																												{
																													val = 0,
																													next = new ListNode()
																													{
																														val = 0,
																														next = new ListNode()
																														{
																															val = 0,
																															next = new ListNode()
																															{
																																val = 0,
																																next = new ListNode()
																																{
																																	val = 1,
																																	next = null
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		};

		public ListNode Param4_2 { get; set; } = new ListNode()
		{
			val = 5,
			next = new ListNode()
			{
				val = 6,
				next = new ListNode()
				{
					val = 4,
					next = null
				}
			}
		};

		#endregion Param4
	}

	//Definition for singly-linked list.
	public class ListNode
	{
		public int val { get; set; }
		public ListNode? next { get; set; }

		public ListNode(int val = 0, ListNode? next = null)
		{
			this.val = val;
			this.next = next;
		}
	}
}
