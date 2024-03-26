using Leetcode.Solutions._1;

namespace Leetcode
{
	internal class Leetcode
	{
		public void ExecSolution(int questionNumber)
		{
			switch (questionNumber)
			{
				case 1:
					Solution solution = new();
					Console.WriteLine(string.Join(", ", solution.TwoSum_BruteForce(solution.Nums1, 9)));
					Console.WriteLine(string.Join(", ", solution.TwoSum_TwoPass(solution.Nums2, 0)));
					Console.WriteLine(string.Join(", ", solution.TwoSum_OnePass(solution.Nums3, 6)));
					Console.WriteLine(string.Join(", ", solution.TwoSum_TwoPass(solution.Nums4, 19999)));
					break;
				default:
					Console.WriteLine($"Question with number = {questionNumber} not found.");
					break;
			}
		}
	}
}
