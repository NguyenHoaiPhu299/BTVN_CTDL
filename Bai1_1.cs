using System;
using System.Diagnostics;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = global::System.Text.Encoding.UTF8;
        // Đo thời gian thực thi
        Stopwatch stopwatch = new Stopwatch();

        // Test cộng các loại dữ liệu khác nhau
        int intResult;
        string stringResult;
        int[] arrayResult;

        // Cộng hai số
        stopwatch.Start();
        intResult = Add(5, 10);
        stopwatch.Stop();
        Console.WriteLine($"Kết quả số: {intResult}, Thời gian thực thi: {stopwatch.ElapsedMilliseconds} ms");

        // Cộng hai xâu
        stopwatch.Restart();
        stringResult = Add("Hello, ", "world!");
        stopwatch.Stop();
        Console.WriteLine($"Kết quả xâu: {stringResult}, Thời gian thực thi: {stopwatch.ElapsedMilliseconds} ms");

        // Cộng hai mảng
        stopwatch.Restart();
        arrayResult = Add(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 });
        stopwatch.Stop();
        Console.WriteLine($"Kết quả mảng: [{string.Join(", ", arrayResult)}], Thời gian thực thi: {stopwatch.ElapsedMilliseconds} ms");
    }

    // Hàm generic để cộng các số và xâu
    static T Add<T>(T a, T b)
    {
        dynamic dynamicA = a;
        dynamic dynamicB = b;
        return dynamicA + dynamicB;
    }

    // Phương thức riêng để cộng hai mảng
    static int[] Add(int[] a, int[] b)
    {

        int[] result = new int[a.Length + b.Length];
        int cnt = 0;
        for (int i = 0; i < a.Length; i++)
        {
            result[cnt++] = a[i];
        }
        for (int i = 0; i < b.Length; i++)
        {
            result[cnt++] = b[i];
        }
        return result;
    }
}
