#r "nuget:  Shouldly , 4.3.0"
using System.Linq;
using System.Numerics;
using Shouldly;

/*
 * @lc app=leetcode id=242 lang=csharp
 *
 * [242] Valid Anagram
 */

// @lc code=start
public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        return new string(s.Order().ToArray()) == new string(t.Order().ToArray());
    }
}

// @lc code=end

bool result;

// Test 1
result = new Solution().IsAnagram("anagram", "nagaram");
result.ShouldBe(true);

// Test 2
result = new Solution().IsAnagram("rat", "car");
result.ShouldBe(false);
