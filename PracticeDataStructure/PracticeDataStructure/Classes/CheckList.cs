using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDataStructure.Classes
{
    public static class CheckList
    {
        public static Dictionary<string, int> ipCounts = new Dictionary<string, int>();

        public static string MostFrequestIp(this List<string> logs)
        {
            string mostFrequentIp = string.Empty;
            foreach (string log in logs)
            {
                string ip = log.Split(' ')[0];
                if (ipCounts.ContainsKey(ip)) 
                {
                    ipCounts[ip]++;
                }
                else
                {
                    ipCounts[ip] = 1;
                }
            }

            int maxvalue = 0;
            foreach (int value in ipCounts.Values)
            {
                if (value > maxvalue) 
                {
                    maxvalue = value;
                }
            }
            foreach(var pair in ipCounts)
            {
                if(pair.Value == maxvalue)
                {
                    mostFrequentIp = pair.Key;
                }
            }
            return mostFrequentIp;
        }

        public static int HighestAverage(this string[,] studentMarks)
        {
            // Variable to track the highest average score
            int maxAverage = 0;
            string higheatAvgName = string.Empty;
            Dictionary<string, List<int>> scoreBoard = new Dictionary<string, List<int>>();
            // Iterate over the 2D array to populate the dictionary
            for (int i = 0; i < studentMarks.GetLength(0); i++)
            {
                string name = studentMarks[i, 0];
                int score = int.Parse(studentMarks[i, 1]);
                if (!scoreBoard.ContainsKey(name))
                {
                    scoreBoard[name] = new List<int>();
                }
                scoreBoard[name].Add(score);
            }
            // Calculate the average for each student and find the highest one
            foreach (var score in scoreBoard)
            {
                int totalScore = score.Value.Sum();
                int count = score.Value.Count();
                int totalAverage = totalScore / count;
                if (totalAverage > maxAverage)
                { maxAverage = totalAverage;
                    higheatAvgName = score.Key;
                }
            }
            Console.WriteLine($"Highest Average of {higheatAvgName} is {maxAverage}");
            return maxAverage;
        }
    }
}
