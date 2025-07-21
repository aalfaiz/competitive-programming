#r "nuget:  Shouldly , 4.3.0"
#load "Utils.csx"
using System;
using Shouldly;

/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var remainderDict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (remainderDict.ContainsKey(nums[i]))
            {
                return [remainderDict[nums[i]], i];
            }
            var remainder = target - nums[i];
            remainderDict.TryAdd(remainder, i);
        }
        return [-1, -1];
    }
}

// @lc code=end

void Test1()
{
    var sol = new Solution();
    var result = sol.TwoSum([2, 7, 11, 15], 9);
    result.ShouldBe([0, 1]);
}

RunTests([Test1]);
