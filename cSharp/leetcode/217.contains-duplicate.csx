#r "nuget:  Shouldly , 4.3.0"
using System.Numerics;
using Shouldly;

/*
 * @lc app=leetcode id=217 lang=csharp
 *
 * [217] Contains Duplicate
 */

// @lc code=start


public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        var hash = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (hash.Contains(nums[i]))
            {
                return true;
            }
            else
            {
                hash.Add(nums[i]);
            }
        }
        return false;
    }
}

// @lc code=end

bool result;

// Test 1
result = new Solution().ContainsDuplicate([1, 2, 3, 1]);
result.ShouldBe(true);

// Test 2
result = new Solution().ContainsDuplicate([1, 2, 3, 4]);
result.ShouldBe(false);

// Test 3
result = new Solution().ContainsDuplicate([1, 1, 1, 3, 3, 4, 3, 2, 4, 2]);
result.ShouldBe(true);

// Test 4
result = new Solution().ContainsDuplicate([0, 4, 5, 0, 3, 6]);
result.ShouldBe(true);
