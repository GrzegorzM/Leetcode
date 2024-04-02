namespace Leetcode
{
	internal class Leetcode
	{
		public void ExecSolution(int questionNumber)
		{
			switch (questionNumber)
			{
				case 1:
					Solutions._1.Solution solution1 = new();
					Console.WriteLine(string.Join(", ", solution1.TwoSum_BruteForce(solution1.Nums1, 9)));
					Console.WriteLine(string.Join(", ", solution1.TwoSum_TwoPass(solution1.Nums2, 0)));
					Console.WriteLine(string.Join(", ", solution1.TwoSum_OnePass(solution1.Nums3, 6)));
					Console.WriteLine(string.Join(", ", solution1.TwoSum_TwoPass(solution1.Nums4, 19999)));
					break;
				case 2:
					Solutions._2.Solution solution2 = new();
					Solutions._2.AlgorithmSolution algorithmSolution2 = new();
					solution2.AddTwoNumbers(solution2.Param1_1, solution2.Param1_2);
					solution2.AddTwoNumbers(solution2.Param2_1, solution2.Param2_2);
					solution2.AddTwoNumbers(solution2.Param3_1, solution2.Param3_2);
					solution2.AddTwoNumbers(solution2.Param4_1, solution2.Param4_2);

					algorithmSolution2.AddTwoNumbers(solution2.Param1_1, solution2.Param1_2);
					algorithmSolution2.AddTwoNumbers(solution2.Param2_1, solution2.Param2_2);
					algorithmSolution2.AddTwoNumbers(solution2.Param3_1, solution2.Param3_2);
					algorithmSolution2.AddTwoNumbers(solution2.Param4_1, solution2.Param4_2);
					break;
				case 3:
					Solutions._3.Solution solution3 = new();
					Console.WriteLine($"Output: {solution3.LengthOfLongestSubstring(solution3.Param1)}");
					Console.WriteLine($"Output: {solution3.LengthOfLongestSubstring(solution3.Param2)}");
					Console.WriteLine($"Output: {solution3.LengthOfLongestSubstring(solution3.Param3)}");
					break;
				case 4:
					Solutions._4.Solution solution4 = new();
					Console.WriteLine($"Output: {solution4.FindMedianSortedArrays(solution4.Param1_1, solution4.Param1_2)}");
					Console.WriteLine($"Output: {solution4.FindMedianSortedArrays(solution4.Param2_1, solution4.Param2_2)}");
					break;
				case 5:
					Solutions._5.Solution solution5 = new();
					Console.WriteLine($"Output: {solution5.LongestPalindrome(solution5.Param1)}");
					Console.WriteLine($"Output: {solution5.LongestPalindrome(solution5.Param2)}");
					break;
				case 6:
					Solutions._6.Solution solution6 = new();
					Console.WriteLine($"Output: {solution6.Convert(solution6.Param1_1, solution6.Param1_2)}");
					Console.WriteLine($"Output: {solution6.Convert(solution6.Param2_1, solution6.Param2_2)}");
					break;
				case 7:
					Solutions._7.Solution solution7 = new();
					Console.WriteLine($"Output: {solution7.Reverse(solution7.Param1)}");
					Console.WriteLine($"Output: {solution7.Reverse(solution7.Param2)}");
					Console.WriteLine($"Output: {solution7.Reverse(solution7.Param3)}");
					break;
				default:
					Console.WriteLine($"Question with number = {questionNumber} not found.");
					break;
			}
		}
	}
}
