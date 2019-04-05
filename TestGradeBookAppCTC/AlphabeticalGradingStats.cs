using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradebookApplication
{
    class AlphabeticalGradingStats
    {
        public AlphabeticalGradingStats()
        {
            APlusGrade = "A+";
            CGrade = "C";
        }
        public  string APlusGrade;
        public  string CGrade;

        public AlphabeticalGradingStats ComputeAlphabeticalGrades(GradeStatistics gradesOfStudents)
        {
            var alphagrading = new AlphabeticalGradingStats();
            

            if (gradesOfStudents.HighestGrade >90)
            {
                Console.WriteLine("The grade for the highestgrader student is :{0}", alphagrading.APlusGrade);
            }
            else if (gradesOfStudents.LowestGrade < 50)
            {
                Console.WriteLine("The grade for the lowestgrader student is :{0}", alphagrading.CGrade);
            }

            return alphagrading;
        }
    }
}
