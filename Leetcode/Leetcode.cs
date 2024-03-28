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
					solution2.AddTwoNumbers(solution2.Param1_1, solution2.Param1_2);
					solution2.AddTwoNumbers(solution2.Param2_1, solution2.Param2_2);
					solution2.AddTwoNumbers(solution2.Param3_1, solution2.Param3_2);
					break;
				default:
					Console.WriteLine($"Question with number = {questionNumber} not found.");
					break;
			}
		}
	}
}
