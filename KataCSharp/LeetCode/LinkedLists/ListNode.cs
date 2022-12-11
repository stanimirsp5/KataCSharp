﻿using System;
using System.Reflection;

namespace KataCSharp.LeetCode.LinkedLists
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }


        public static ListNode LinkedListFromArray(int[] arr)
        {
            var root = new ListNode(arr[0]);

            BuildLinkedList(arr,1,root);

            return root;
        }

        private static void BuildLinkedList(int[] arr, int index, ListNode node)
        {
            if (arr.Length == index) return;

            node.next = new ListNode(arr[index]);
            BuildLinkedList(arr, index + 1, node.next);
        }

    }
}

