using System;
using System.Diagnostics;

class SubjectGradesTracker
{
    private string subjectName;
    private int[] grades;

    public SubjectGradesTracker(string subjectName, int[] grades)
    {
        this.subjectName = subjectName;
        this.grades = grades;
    }

    public double CalculateAverageGrade()
    {
        if (grades.Length == 0)
        {
            return 0;
        }

        double total = 0;
        foreach (int grade in grades)
        {
            total += grade;
        }

        return total / grades.Length;
    }

    public int FindHighestGrade()
    {
        if (grades.Length == 0)
        {
            return 0;
        }

        int highestGrade = grades[0];
        foreach (int grade in grades)
        {
            if (grade > highestGrade)
            {
                highestGrade = grade;
            }
        }

        return highestGrade;
    }

    public int FindLowestGrade()
    {
        if (grades.Length == 0)
        {
            return 0;
        }

        int lowestGrade = grades[0];
        foreach (int grade in grades)
        {
            if (grade < lowestGrade)
            {
                lowestGrade = grade;
            }
        }

        return lowestGrade;
    }
    public string GetSubjectName()
    {
        string s;
        s = subjectName;
        return s;
    }
}

class Bai1
{
    static void Main()
    {
        int[] grades = { 85, 90, 78, 92, 88 };
        SubjectGradesTracker subject = new SubjectGradesTracker("Math", grades);

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        double average = subject.CalculateAverageGrade();
        int highestGrade = subject.FindHighestGrade();
        int lowestGrade = subject.FindLowestGrade();

        stopwatch.Stop();
        TimeSpan elapsedTime = stopwatch.Elapsed;

        Console.WriteLine("Subject: " + subject.GetSubjectName());
        Console.WriteLine("Average Grade: " + average);
        Console.WriteLine("Highest Grade: " + highestGrade);
        Console.WriteLine("Lowest Grade: " + lowestGrade);
        Console.WriteLine("Elapsed Time: " + elapsedTime.TotalMilliseconds + " milliseconds");
    }
}
