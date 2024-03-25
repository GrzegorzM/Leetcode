namespace Leetcode.Solutions._1
{
	internal class Solution
	{
		public int[] TwoSum_BruteForce(int[] nums, int target)
		{
			int i = 0;
			int[] result = new int[2];
			foreach (int number in nums)
			{
				int j = 0;
				foreach (int number2 in nums)
				{
					if (i == j)
					{
						j++;
						continue;
					}

					if (number + number2 == target)
					{
						result[0] = i;
						result[1] = j;

						return result;
					}
					j++;
				}
				i++;
			}

			return [];
		}
	}
}