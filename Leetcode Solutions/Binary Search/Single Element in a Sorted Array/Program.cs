﻿using System;

//You are given a sorted array consisting of only integers where every element appears exactly twice, except for one element which appears exactly once. 
//Find this single element that appears only once.
//Follow up: Your solution should run in O(log n) time and O(1) space.
namespace Single_Element_in_a_Sorted_Array
{
    class Program
    {
        // EXPLANATION:-
        // Suppose array is [1, 1, 2, 2, 3, 3, 4, 5, 5]
        // we can observe that for each pair, 
        // first element takes even position and second element takes odd position
        // for example, 1 is appeared as a pair,
        // so it takes 0 and 1 positions. similarly for all the pairs also.
        // this pattern will be missed when single element is appeared in the array.
        // From these points, we can implement algorithm.

        // 1. Take left and right pointers . 
        // left points to start of list. right points to end of the list.

        // 2. find mid.
        // if mid is even, then it's duplicate should be in next index.
        // or if mid is odd, then it's duplicate  should be in previous index.
        // check these two conditions, 
        // if any of the conditions is satisfied,
        // then pattern is not missed, 
        // so check in next half of the array. i.e, left = mid + 1
        // if condition is not satisfied, then the pattern is missed.
        // so, single number must be before mid.
        // so, update end to mid.

        // 3. At last return the nums[left]

        // Time: -  O(logN)
        // space:-  O(1)
        static void Main(string[] args)
        {
            int[] nums = new int[] {1,1,2,2,4,4,5,8,8};
            int left = 0;
            int right = nums.Length;
            while(left < right)
            {
                int mid = left + (right - left) / 2;

                if(mid % 2 == 0 && nums[mid+1] == nums[mid] || mid % 2 == 1 && nums[mid-1] == nums[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
                
            }
            Console.WriteLine(nums[right]);
            
        }
    }
}
