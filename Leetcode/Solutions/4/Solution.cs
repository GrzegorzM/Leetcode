namespace Leetcode.Solutions._4
{
	internal class Solution
	{
		public double FindMedianSortedArrays(int[] nums1, int[] nums2)
		{
			// Slower
			//List<int> concatenatedArrays = nums1.Concat(nums2)
			//	.OrderBy(x => x)
			//	.ToList();

			// Faster
			int[] concatenatedArrays = nums1.Concat(nums2)
					//.OrderBy(x => x)
					.ToArray();

			Array.Sort(concatenatedArrays);

			int mergedArrayLength = concatenatedArrays.Length;
			if (mergedArrayLength % 2 == 0)
			{
				return (double)(concatenatedArrays[(mergedArrayLength / 2) - 1] + concatenatedArrays[mergedArrayLength / 2]) / 2;
			}
			else
			{
				return concatenatedArrays[mergedArrayLength / 2];
			}
		}

		#region Param 1
		public int[] Param1_1 { get; set; } = [1, 3];

		public int[] Param1_2 { get; set; } = [2];
		#endregion

		#region Param2
		public int[] Param2_1 { get; set; } = [1, 2];

		public int[] Param2_2 { get; set; } = [3, 4];
		#endregion
	}
}
