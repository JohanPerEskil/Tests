using System;
public partial class Program
{
    public static void Main(string[] args)
    {
        int i, n;
        int[] a = new int[100];
        Console.Write("\n\nRead n number of values in an array and display it in reverse order:\n");
        Console.Write("------------------------------------------------------------------------\n");
        Console.Write("Input the number of elements to store in the array :");
        n = Convert.ToInt32(Console.ReadLine());
        //quantity of numbers to insert
        Console.Write("Input {0} number of elements in the array :\n", n);
        for (i = 0; i < n; i++)
        {
            Console.Write("element - {0} : ", i);
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        //individual numbers to insert
        Console.Write("\nThe values store into the array are : \n");
        for (i = 0; i < n; i++)
        {
            Console.Write("{0}  ", a[i]);
        }
    }
}
public static class Extensions
{
    public static decimal GetMedian(this int[] array)
    {
        int[] tempArray = array;
        int count = tempArray.Length;
        Array.Sort(tempArray);
        decimal medianValue = 0;
        if (count % 2 == 0)
        {
            // count is even, need to get the middle two elements, add them together, then divide by 2
            int middleElement1 = tempArray[(count / 2) - 1];
            int middleElement2 = tempArray[(count / 2)];
            medianValue = (middleElement1 + middleElement2) / 2;
        }
        else
        {
            // count is odd, simply get the middle element.
            medianValue = tempArray[(count / 2)];
        }
        return medianValue;
    }
}