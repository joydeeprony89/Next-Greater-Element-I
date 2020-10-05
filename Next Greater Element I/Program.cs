using System;
using System.Collections.Generic;

namespace Next_Greater_Element_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // https://leetcode.com/problems/next-greater-element-i/discuss/97595/Java-10-lines-linear-time-complexity-O(n)-with-explanation
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            Stack<int> stack = new Stack<int>();
            foreach (int num in nums2)
            {
                while (stack.Count > 0 && stack.Peek() < num)
                {
                    pairs.Add(stack.Peek(), num);
                }
                stack.Push(num);
            }
            for (int i = 0; i < nums1.Length; i++)
            {
                nums1[i] = pairs.GetValueOrDefault(nums1[i], -1);
            }
            return nums1;
        }
    }
}
