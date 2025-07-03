/*
 * @lc app=leetcode id=49 lang=csharp
 *
 * [49] Group Anagrams
 */

// @lc code=start
public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        if (strs.Length == 1 && strs[0] == "")
        {
            return
            [
                [""]
            ];
        }

        var anagrams = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            var sortedStr = new string(str.Order().ToArray());
            if (anagrams.ContainsKey(sortedStr))
            {
                anagrams[sortedStr].Add(str);
            }
            else
            {
                anagrams.Add(new string(sortedStr.ToArray()), [str]);
            }
        }

        var result = anagrams.Select(x => x.Value).ToList();

        return result.Cast<IList<string>>().ToList();
    }
}

// @lc code=end

IList<IList<string>> result;

// Test 1
result = new Solution().GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
result.Equals(
    new List<IList<string>>
    {
        new List<string> { "bat" },
        new List<string> { "nat", "tan" },
        new List<string> { "ate", "eat", "tea" }
    }
);

// Test 2
result = new Solution().GroupAnagrams(new string[] { "" });
result.Equals(new List<IList<string>> { new List<string> { "" }, });

// Test 3
result = new Solution().GroupAnagrams(new string[] { "a" });
result.Equals(new List<IList<string>> { new List<string> { "a" }, });
