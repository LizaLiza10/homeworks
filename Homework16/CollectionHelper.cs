using System;
using System.Collections.Generic;
using System.Text;

namespace Homework16
{
    internal class CollectionHelper
    {
        public List<string> students = new List<string>();
        public Dictionary<string, int> scores = new Dictionary<string, int>();

        public void AddStudent(string name, int score)
        {
            if (!scores.ContainsKey(name))
            {
                students.Add(name);
                scores.Add(name, score);
            }
            else
            {
                Console.WriteLine("Student already exists.");
            }
        }

        public void SearchStudent(string name)
        {
            if (scores.ContainsKey(name))
                Console.WriteLine(name + ": " + scores[name]);
            else
                Console.WriteLine("სტუდენტი ვერ მოიძებნა");
        }

        public void UpdateScore(string name, int newScore)
        {
            if (scores.ContainsKey(name))
                scores[name] = newScore;
            else
                Console.WriteLine("სტუდენტი ვერ მოიძებნა");
        }

        public void ShowAll()
        {
            foreach (string name in students)
                Console.WriteLine(name + ": " + scores[name]);
        }
    }

}

