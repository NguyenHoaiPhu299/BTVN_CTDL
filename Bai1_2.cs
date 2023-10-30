using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    #region Class Timing
    /*public class Timing
    {
        TimeSpan startingTime;
        TimeSpan duration;
        public Timing()
        {
            startingTime = new TimeSpan(0);
            duration = new TimeSpan(0);
        }

        public void StopTime()
        {
            duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(startingTime);
        }

        public void startTime()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            startingTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;
        }

        public TimeSpan Result()
        {
            return duration;
        }
    }*/
    #endregion
    public class Program
    {
            static void Main()
            {
            Console.OutputEncoding = global::System.Text.Encoding.UTF8;
                // Tạo mảng chứa 1000 số nguyên ngẫu nhiên
                int[] numbers = new int[1000];
                Random random = new Random();

                for (int i = 0; i < 1000; i++)
                {
                    numbers[i] = random.Next();
                }

                // Tạo một đối tượng Stopwatch để đo thời gian
                Stopwatch stopwatch = new Stopwatch();

                // Bắt đầu đo thời gian
                stopwatch.Start();

                // Gọi hàm để tìm số nguyên nhỏ nhất và lớn nhất
                int min = FindMin(numbers);
                int max = FindMax(numbers);

                // Dừng đo thời gian
                stopwatch.Stop();

                Console.WriteLine("Số nguyên nhỏ nhất: " + min);
                Console.WriteLine("Số nguyên lớn nhất: " + max);
                Console.WriteLine("Thời gian thực thi: " + stopwatch.Elapsed.TotalMilliseconds + " ms");
            }

            static int FindMin(int[] numbers)
            {
                int min = numbers[0];
                foreach (int number in numbers)
                {
                    if (number < min)
                    {
                        min = number;
                    }
                }
                return min;
            }

            static int FindMax(int[] numbers)
            {
                int max = numbers[0];
                foreach (int number in numbers)
                {
                    if (number > max)
                    {
                        max = number;
                    }
                }
                return max;
            }
        }
}
