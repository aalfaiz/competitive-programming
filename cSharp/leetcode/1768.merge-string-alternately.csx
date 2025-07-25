#r "nuget:  Shouldly , 4.3.0"
#load "Utils.csx"
using System;
using Shouldly;

/*
 * @lc app=leetcode id=1768 lang=csharp
 *
 * [1768] Merge Strings Alternately
 */

// @lc code=start
public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        var minLength = Math.Min(word1.Length, word2.Length);
        var word = "";
        for (int i = 0; i < minLength; i++)
        {
            word += word1[i].ToString() + word2[i].ToString();
        }

        word +=
            word1.Length > word2.Length
                ? word1[(minLength)..word1.Length]
                : word2[(minLength)..word2.Length];

        return word;
    }
}

// @lc code=end


void Test1()
{
    var result = new Solution().MergeAlternately("abc", "pqr");
    result.ShouldBe("apbqcr");
}

void Test2()
{
    var result = new Solution().MergeAlternately("ab", "pqrs");
    result.ShouldBe("apbqrs");
}

void Test3()
{
    var result = new Solution().MergeAlternately("abcd", "pq");
    result.ShouldBe("apbqcd");
}

RunTests([Test1, Test2, Test3]);
