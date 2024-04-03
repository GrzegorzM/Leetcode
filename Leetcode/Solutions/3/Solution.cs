namespace Leetcode.Solutions._3
{
	// Brute Force
	internal class Solution
	{
		public int LengthOfLongestSubstring(string s)
		{
			int longestSubstringLength = 0;

			for (int i = 0; i < s.Length; i++)
			{
				int substringLength = IterateThroughString(s.Substring(i));

				longestSubstringLength = longestSubstringLength < substringLength
					? substringLength
					: longestSubstringLength;
			}

			return longestSubstringLength;
		}

		private static int IterateThroughString(string s)
		{
			HashSet<char> nonDuplicateLetters = new();

			foreach (char letter in s)
			{
				if (nonDuplicateLetters.Contains(letter))
				{
					return nonDuplicateLetters.Count;
				}

				nonDuplicateLetters.Add(letter);
			}

			return nonDuplicateLetters.Count;
		}

		public string Param1 { get; set; } = "abcabcbb";

		public string Param2 { get; set; } = "bbbbb";

		public string Param3 { get; set; } = "pwwkew";

		public string Param4 { get; set; } = " ";
	}
}
