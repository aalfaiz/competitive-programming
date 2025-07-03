#r "nuget:  Shouldly , 4.3.0"
using Shouldly;
using Shouldly.Configuration;

/*
 * @lc app=leetcode id=347 lang=csharp
 *
 * [347] Top K Frequent Elements
 */

// @lc code=start

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var result = nums.GroupBy(x => x).ToList(); //.OrderBy(x => x.Key).Select(x => x.Key).Take(k).ToArray();
        Console.WriteLine(result.ToList());
        return [];
    }
}

// @lc code=end
int[] result;
result = new Solution().TopKFrequent([1, 1, 1, 2, 2, 3], 2);
result.ShouldBe([1, 2]);

result = new Solution().TopKFrequent([1], 1);
result.ShouldBe([1]);

// Additional unit tests for TopKFrequent method

result = new Solution().TopKFrequent([4, 4, 4, 6, 6, 7, 7, 7, 8], 2);
result.ShouldBe(new[] { 7, 4 }, ignoreOrder: true);

result = new Solution().TopKFrequent([5, 5, 5, 5, 5], 1);
result.ShouldBe([5]);

result = new Solution().TopKFrequent([1, 2, 3, 4, 5], 3);
result.ShouldBe(new[] { 1, 2, 3 }, ignoreOrder: true);

result = new Solution().TopKFrequent([2, 2, 3, 3, 4, 4], 2);
result.ShouldBe(new[] { 2, 3 }, ignoreOrder: true);

result = new Solution().TopKFrequent([1, 2, 2, 3, 3, 3, 4, 4, 4, 4], 1);
result.ShouldBe([4]);

result = new Solution().TopKFrequent([100], 1);
result.ShouldBe([100]);

result = new Solution().TopKFrequent([1, 2, 3, 4, 5], 5);
result.ShouldBe(new[] { 1, 2, 3, 4, 5 }, ignoreOrder: true);
