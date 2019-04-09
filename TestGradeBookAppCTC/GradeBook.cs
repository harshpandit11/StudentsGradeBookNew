using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TestGradeBookAppCTC;

namespace GradebookApplication
{
    public class GradeBook : GradeTracker
    {


        public override void WriteGrades(StreamWriter destination)
        {
            for (int i = grades.Count(); i > 0; i--)
            {
                //writeline - writes the cahracter or grades inside of destniation onto the text file created in main
                destination.WriteLine(grades[i - 1]);
            }
        }

        public GradeBook()
        {
            _name = "DefaultGradebookName";
            grades = new List<double>();
        }
        public override void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        protected List<double> grades;

        public override IEnumerator GetEnumerator()
       {
        return grades.GetEnumerator();
       }
        public override GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            AlphabeticalGradingStats it = new AlphabeticalGradingStats();
            double sum1 = 0;
            foreach (double grade in grades)
            {
                sum1 = sum1 + grade;
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);

            } 
            var countoffailures = 0;
            stats.Aggregate = sum1;
            stats.AverageGrade = sum1 / grades.Count;
            for (int i = 0; i < grades.Count(); i++)
            {
                if (grades[i] <= stats.FailureGrade)
                {
                    countoffailures++;
                    continue;
                }

            }
            if (countoffailures <=0)
            {
                Console.WriteLine("Great ,you have not failed in any of the subjects");
            }
            else
            {
                Console.WriteLine($"You have failed in {countoffailures} subjects as the marks are less than 35");
            }
            
            return stats;
        }



    }



}


