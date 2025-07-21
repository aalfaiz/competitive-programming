#r "nuget:  Shouldly , 4.3.0"
#load "Utils.csx"

using System;
using Shouldly;

/*
 * @lc app=leetcode id=21 lang=csharp
 *
 * [21] Merge Two Sorted Lists
 */




// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode list = list1;
        if (list1 != null && list2 == null)
        {
            return list1;
        }
        else if (list1 == null && list2 != null)
        {
            return list2;
        }
        else if (list1 == null && list2 == null)
        {
            return null;
        }
        else
        {
            while (list2 != null)
            {
                list.next = list2;
                list2 = list2.next;
            }
        }

        return list;
    }
}

// @lc code=end

public class ListNode(int val = 0, ListNode next = null)
{
    public int val = val;
    public ListNode next = next;
}

ListNode BuildList(int[] values)
{
    ListNode dummy = new();
    ListNode current = dummy;
    foreach (var v in values)
    {
        current.next = new ListNode(v);
        current = current.next;
    }
    return dummy.next;
}

string PrintList(ListNode node)
{
    var list = string.Empty;
    while (node != null)
    {
        list = list + node.val + (node.next != null ? "->" : "");
        node = node.next;
    }
    return list;
}

// Test case

void Test1()
{
    var list1 = BuildList([1, 2, 4]);
    var list2 = BuildList([1, 3, 4]);
    var merged = new Solution().MergeTwoLists(list1, list2);
    PrintList(merged).ShouldBe("1->1->2->3->4->4");
}

void Test2()
{
    var list1 = BuildList([2, 2, 4]);
    var list2 = BuildList([1, 3, 4]);
    var merged = new Solution().MergeTwoLists(list1, list2);
    PrintList(merged).ShouldBe("1->2->2->3->4->4");
}

void TestEmptyList()
{
    var list1 = BuildList([]);
    var list2 = BuildList([]);
    var merged = new Solution().MergeTwoLists(list1, list2);
    PrintList(merged).ShouldBe("");
}

RunTests([Test1, Test2, TestEmptyList], true);
