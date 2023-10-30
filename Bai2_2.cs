using System;
using System.Collections.Generic;

class SubjectGradesTracker
{
    private string subjectName;
    private List<int> grades;

    public SubjectGradesTracker(string subjectName)
    {
        this.subjectName = subjectName;
        this.grades = new List<int>();
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

class Program
{
    static void Main()
    {
        List<SubjectGradesTracker> subjects = new List<SubjectGradesTracker>();
        subjects.Add(new SubjectGradesTracker("Math"));
        subjects.Add(new SubjectGradesTracker("English"));

        subjects[0].AddGrade(85);
        subjects[0].AddGrade(90);
        subjects[1].AddGrade(78);
        subjects[1].AddGrade(92);
        subjects[1].AddGrade(88);

        foreach (var subject in subjects)
        {
            double average = subject.CalculateAverageGrade();
            int highestGrade = subject.FindHighestGrade();
            int lowestGrade = subject.FindLowestGrade();

            Console.WriteLine("Subject: " + subject.GetSubjectName());
            Console.WriteLine("Average Grade: " + average);
            Console.WriteLine("Highest Grade: " + highestGrade);
            Console.WriteLine("Lowest Grade: " + lowestGrade);
        }
    }
}
