# TraverseStackArray
Given an array of integers temperatures represents the daily temperatures, return an array answer such that answer[i] is the number of days you have to wait after the ith day to get a warmer temperature. If there is no future day for which this is possible, keep answer[i] == 0 instead.

<p><b>Example 1:</b></p>

Input: temperatures = [73,74,75,71,69,72,76,73]
Output: [1,1,4,2,1,1,0,0]

<p><b>Example 2:</b></p>

Input: temperatures = [30,40,50,60]
Output: [1,1,1,0]

<p><b>Example 3:</p></b>

Input: temperatures = [30,60,90]
Output: [1,1,0]
 

<p><b>Constraints:</p></b>

1 <= temperatures.length <= 105
30 <= temperatures[i] <= 100
