using System;
using System.Collections.Generic;
using System.IO;

class HtmlTagValidator
{
    static bool IsHtmlTag(string line)
    {
        line = line.Trim();

        if (line.StartsWith("<") && line.EndsWith(">"))
        {
            if (line[1] != '/')
            {
                tagQueue.Enqueue(line);
            }
            else
            {
                string openTag = tagQueue.Dequeue();
                if (line.Substring(2) != openTag.Substring(1))
                {
                    return false;
                }
            }
        }
        return true;
    }

    static Queue<string> tagQueue = new Queue<string>();

    static void Main()
    {
        string filePath = "example.html"; 

        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (!IsHtmlTag(line))
                    {
                        Console.WriteLine("Invalid HTML Tags: " + line);
                        return;
                    }
                }

                if (tagQueue.Count == 0)
                {
                    Console.WriteLine("HTML Tags are valid.");
                }
                else
                {
                    Console.WriteLine("Some HTML Tags are not closed.");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }
    }
}
