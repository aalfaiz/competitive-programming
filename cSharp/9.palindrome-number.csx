#r "nuget: FluentAssertions, 6.12.0"
using FluentAssertions;
using FluentAssertions.Execution;

/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;
        var number = x.ToString();
        for (var i = 0; i < number.Length / 2; i++)
        {
            if (number[i] != number[number.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}

// @lc code=end



var sol = new Solution();

// test 1
var result1 = sol.IsPalindrome(121);
result1.Should().Be(true, "It should be true 121 is palindrome");

// test 2
var result2 = sol.IsPalindrome(-121);
result2.Should().Be(false, "It Should False because -121 is not a palindrome number.");

// test 3
var result3 = sol.IsPalindrome(10);
result3.Should().Be(false, "It should be false because 10 is not a palindrome number.");

// test 4
var result4 = sol.IsPalindrome(1001);
result4.Should().Be(true, "It should be true");
