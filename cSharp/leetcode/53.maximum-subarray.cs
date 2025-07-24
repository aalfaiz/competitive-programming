#r "nuget:  Shouldly , 4.3.0"
#load "Utils.csx"
using System;
using Shouldly;



/// <summary>
///  TIME LIMIT EXCEEDED
/// </summary>
/// <param name="nums"></param>
/// <returns></returns>
public int MaxSubArrayLimit(int[] nums) {
    var maxSum = nums[0];
    
    for(int i=0; i < nums.Length; i++){
        var currentSum = 0;
        for (int j = i; j < nums.Length; j++){
            currentSum += nums[j];
            if(maxSum < currentSum){
                maxSum = currentSum;
            }
        }
    }

    return maxSum;
}

/*
 * @lc app=leetcode id=53 lang=csharp
 *
 * [53] Maximum Subarray
 */

// @lc code=start
public class Solution
{
    /// <summary>
    ///  
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MaxSubArray(int[] nums) {
        var maxSum = nums[0];
        var currentSum = nums[0];
        for(int i=1; i < nums.Length; i++){
            currentSum = Math.Max(nums[i], currentSum + nums[i]);
            maxSum = Math.Max(currentSum, maxSum);
        }

        return maxSum;
    }
}
// @lc code=end


void Test1(){
    var result = new Solution().MaxSubArray([-2, 1, -3, 4, -1, 2, 1, -5, 4]);
    result.ShouldBe(6);
}

void Test2(){
    var result = new Solution().MaxSubArray([1]);
    result.ShouldBe(1);
}

void Test3(){
    var result = new Solution().MaxSubArray([5,4,-1,7,8]);
    result.ShouldBe(23);
}

void Test4(){
    var result = new Solution().MaxSubArray([0,4]);
    result.ShouldBe(4);
}

RunTests([Test1, Test2, Test3, Test4]);