using Leetcode.Solutions._1;
Console.WriteLine("Type question number");
int questionNumber = Convert.ToInt32(Console.ReadLine());

switch (questionNumber)
{
	case 1:
		Console.WriteLine(new Solution().TwoSum_BruteForce([2, 7, 11, 15], 9));
		break;
	default:
		Console.WriteLine($"Question with number = {questionNumber} not found.");
		break;
}