namespace Leetcode.Solutions._3
{
	// Two pointers + Hash Table (Sliding Window Technique)
	internal class AlgorithmSolution
	{
		public int LengthOfLongestSubstring(string s)
		{
			HashSet<char> recordChars = new();
			int ans = 0;

			for (int i = 0, j = 0; j < s.Length; j++)
			{
				while (recordChars.Contains(s[j]))
				{
					recordChars.Remove(s[i++]);
				}

				recordChars.Add(s[j]);
				ans = Math.Max(ans, recordChars.Count);
			}

			return ans;
		}
	}
}
