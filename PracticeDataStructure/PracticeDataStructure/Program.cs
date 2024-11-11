// See https://aka.ms/new-console-template for more information
using PracticeDataStructure.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        NewDataStructures();
        //Console.WriteLine("Array!");

        //int[] arr = { 7, 8, 1, 2, 3, 4, 5, 12 };
        //string[,] studentMarks = {
        //    {"Bob", "87"},
        //    {"Jessica", "95"},
        //    {"Bob", "98"},
        //    {"Bob", "95"},
        //    {"Mike", "35"},
        //    {"Bob", "52"},
        //    {"Jason", "35"},
        //    {"Mike", "55"},
        //    {"Jessica", "99"}
        //};

        ////studentMarks.HighestAverage();

        //string inputString = "aaaatbbtooommmmm";
        //inputString.InputStringEncoding();
        // Sort the array in descending order using Counting Sort
        //arr.SortyArrayDescendingOrder();

        //// Output the sorted array
        //Console.WriteLine("Sorted Array in Descending Order:");
        //Console.WriteLine(string.Join(", ", arr));

        //Find Secont smallest element
        //var smallestElement = arr.SecondSmallestElement();
        ////Output second smallest Element
        //Console.WriteLine(string.Join(", ", arr));
        //Console.WriteLine($"The smallest element is {smallestElement.ToString()}");

        // Example input
        //List<string> logs = new List<string> { "10.0.0.1 - GET 2020-08-24", "10.0.0.1 - GET 2020-08-24", "10.0.0.2 - GET 2020-08-20", "10.0.0.3 - GET 2024-08-20", "10.0.0.3 - GET 2023-08-20", "10.0.0.3 - GET 2022-08-20" };
        //logs.MostFrequestIp();
    }

    private static void NewDataStructures()
    {
        int[] array1 = { 4,5,6 };
        int[] array2 = { 1,2,3 };
        array1.FindMedianSortedArrays(array2);
    }
}