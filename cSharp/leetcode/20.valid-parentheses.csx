#r "nuget:  Shouldly , 4.3.0"
using System;
using Shouldly;

/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */

// @lc code=start
public class Solution
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        var isValid = true;
        List<char> openBrackets = ['[', '(', '{'];
        List<char> closesBrackets = [']', ')', '}'];
        foreach (char c in s)
        {
            if (openBrackets.Contains(c))
            {
                stack.Push(c);
            }
            else if (closesBrackets.Contains(c))
            {
                if (stack.Count == 0)
                {
                    isValid = false;
                    break;
                }
                var topChar = stack.Peek();
                isValid = (topChar, c) switch
                {
                    ('(', ')') => true,
                    ('[', ']') => true,
                    ('{', '}') => true,
                    _ => false
                };

                if (isValid)
                {
                    stack.Pop();
                }
                else
                {
                    isValid = false;
                    break;
                }
            }
        }

        return isValid;
    }
}

// @lc code=end


// Example Shouldly test case for IsValid
new Solution()
    .IsValid("()")
    .ShouldBe(true);
new Solution().IsValid("()[]{}").ShouldBe(true);
new Solution().IsValid("(]").ShouldBe(false);
new Solution().IsValid("([)]").ShouldBe(false);
new Solution().IsValid("{[]}").ShouldBe(true);
new Solution().IsValid("").ShouldBe(true);
new Solution().IsValid("(((((").ShouldBe(false);
new Solution().IsValid("(()())").ShouldBe(true);
