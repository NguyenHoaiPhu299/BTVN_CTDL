using System;
using System.Collections;
using System.Diagnostics;

class SubjectGradesTracker
{
    private string subjectName;
    private ArrayList grades;

    public SubjectGradesTracker(string subjectName)
    {
        this.subjectName = subjectName;
        this.grades = new ArrayList();
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

        int highestGrade = (int)grades[0];
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

        int lowestGrade = (int)grades[0];
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

class Bai4
{
    static void Main()
    {
        SubjectGradesTracker subject = new SubjectGradesTracker("Math");
        subject.AddGrade(85);
        subject.AddGrade(90);
        subject.AddGrade(78);
        subject.AddGrade(92);
        subject.AddGrade(88);

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
