using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Buoi4
{
    public class Timing
    {
        private Stopwatch stopwatch;

        public Timing()
        {
            stopwatch = new Stopwatch();
        }

        public void Start()
        {
            stopwatch.Start();
        }

        public void Stop()
        {
            stopwatch.Stop();
        }

        public TimeSpan ElapsedTime()
        {
            return stopwatch.Elapsed;
        }
    }
    public class SearchAlgorithm
    {
        public static int SenSearch(int[] a, int value)
        {
            int x = a[a.Length - 1];
            a[a.Length - 1] = value;
            int i = 0;
            while (a[i] != value)
            {
                i++;
            }
            a[a.Length - 1] = x;
            if (i < a.Length - 1 || a[a.Length - 1] == value)
            {
                return i;
            }
            else return -1;
        }
        public static int SeqSearch(int[] a, int value)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int RecuSearch(int[] a, int index, int value)
        {
            if (index == a.Length)
            {
                return -1;
            }
            if (a[index] == value)
            {
                return index;
            }
            return RecuSearch(a, index + 1, value);
        }
        
        public static int BinSearch(int[] a, int value)
        {
            int left = 0, right = a.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (a[mid] < value)
                {
                    left = mid + 1;
                }
                else if (a[mid] > value)
                {
                    right = mid - 1;
                }
                else return mid;
            }
            return -1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 7, 9, 11, 13, 15 };
            int value = 11;

            // Đo thời gian cho SeqSearch
            Timing timing1 = new Timing();
            timing1.Start();
            int seqSearchResult = SearchAlgorithm.SeqSearch(array, value);
            timing1.Stop();
            Console.WriteLine("Sequential Search Result: " + seqSearchResult);
            Console.WriteLine("Sequential Search Time: " + timing1.ElapsedTime().TotalSeconds.ToString("F6"));

            // Đo thời gian cho RecuSearch
            Timing timing2 = new Timing();
            timing2.Start();
            int recuSearchResult = SearchAlgorithm.RecuSearch(array, 0, value);
            timing2.Stop();
            Console.WriteLine("Recursive Search Result: " + recuSearchResult);
            Console.WriteLine("Recursive Search Time: " + timing2.ElapsedTime().TotalSeconds.ToString("F6"));

            // Đo thời gian cho SenSearch
            Timing timing3 = new Timing();
            timing3.Start();
            int senSearchResult = SearchAlgorithm.SenSearch(array, value);
            timing3.Stop();
            Console.WriteLine("Sentinel Search Result: " + senSearchResult);
            Console.WriteLine("Sentinel Search Time: " + timing3.ElapsedTime().TotalSeconds.ToString("F6"));

            // Đo thời gian cho BinSearch
            Timing timing4 = new Timing();
            timing4.Start();
            int binSearchResult = SearchAlgorithm.BinSearch(array, value);
            timing4.Stop();
            Console.WriteLine("Binary Search Result: " + binSearchResult);
            Console.WriteLine("Binary Search Time: " + timing4.ElapsedTime().TotalSeconds.ToString("F6"));

            Console.ReadKey();
        }
    }
}
