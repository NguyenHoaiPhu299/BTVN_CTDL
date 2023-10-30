using System;
using System.Collections.Generic;
using System.Diagnostics;

class SubjectGradesTracker
{
    private string subjectName;
    private List<int> grades = new List<int>();

    public SubjectGradesTracker(string subjectName)
    {
        this.subjectName = subjectName;
    }

    public void AddGrade(int grade)
    {
        grades.Add(grade);
    }

    public double CalculateAverageGrade()
    {
        if (grades.Count == 0)
        {
            return 0;
        }

        double total = 0;
        foreach (int grade in grades)
        {
            total += grade;
        }

        return total / grades.Count;
    }

    public int FindHighestGrade()
    {
        if (grades.Count == 0)
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
        if (grades.Count == 0)
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

class Bai3
{
    static void Main()
    {
        SubjectGradesTracker mathSubject = new SubjectGradesTracker("Math");
        mathSubject.AddGrade(85);
        mathSubject.AddGrade(90);
        mathSubject.AddGrade(78);
        mathSubject.AddGrade(92);
        mathSubject.AddGrade(88);

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        double mathAverage = mathSubject.CalculateAverageGrade();
        int mathHighestGrade = mathSubject.FindHighestGrade();
        int mathLowestGrade = mathSubject.FindLowestGrade();

        stopwatch.Stop();
        TimeSpan elapsedTime = stopwatch.Elapsed;

        Console.WriteLine("Subject: " + mathSubject.GetSubjectName());
        Console.WriteLine("Average Grade: " + mathAverage);
        Console.WriteLine("Highest Grade: " + mathHighestGrade);
        Console.WriteLine("Lowest Grade: " + mathLowestGrade);
        Console.WriteLine("Elapsed Time: " + elapsedTime.TotalMilliseconds + " milliseconds");
    }
}
