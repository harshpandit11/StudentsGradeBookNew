using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradebookApplication
{
   
    public class GradeStatistics
    {

        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = double.MaxValue;
            Aggregate = 0;
            FailureGrade = 35;
        }
        public double AverageGrade;
        public double HighestGrade;
        public double LowestGrade;
        public double Aggregate;
        public double FailureGrade;

        public string LetterGrades
        {
            get
            {
                string result = "";
                if (AverageGrade >= 100)
                {
                    result = "A";
                }
                else if (AverageGrade >= 80)
                {
                    result = "B";
                }
                else if (AverageGrade >= 60)
                {
                    result = "C";
                }
                else if (AverageGrade >= 40)
                {
                    result = "D";
                }
                else
                    result = "F";
                return result;
            }

         }
        public string LetterGradeDescription
        {
            get
            {
                switch (LetterGrades)
                {
                    case "A":
                        Console.WriteLine("Excellent you have a A Grade");
                        break;
                    case "B":
                        Console.WriteLine("Very Good you have an B grade");
                        break;
                    case "C":
                        Console.WriteLine("Good you have an C grade");
                        break;
                    case "D":
                        Console.WriteLine("Poor you have an D grade");
                        break;
                    case "F":
                        Console.WriteLine("Very Poor. You have failed");
                        break;
                    default:
                        break;

                }
                return LetterGrades;

            }
        }

    }
}
