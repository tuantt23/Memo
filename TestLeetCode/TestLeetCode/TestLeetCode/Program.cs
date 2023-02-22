using System;
using System.Collections.Generic;
using System.Linq;

namespace TestLeetCode
{
    public class Solution
    {
        //Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
        //Input: prices = [7,1,5,3,6,4]
        //Output: 5
        //Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        //Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        
        public int MaxProfit(int[] prices)
        {
            var maxProfit = 0;
            int leftPointer = 0;
            int rightPointer = 1;
            while (rightPointer < prices.Length)
            {
                if (prices[rightPointer] > prices[leftPointer])
                {
                    var profit = prices[rightPointer] - prices[leftPointer];
                    maxProfit = Math.Max(profit, maxProfit);
                }
                else
                {
                    leftPointer = rightPointer;
                }
                    rightPointer++;
            }
            return maxProfit;
        }
    }
}
