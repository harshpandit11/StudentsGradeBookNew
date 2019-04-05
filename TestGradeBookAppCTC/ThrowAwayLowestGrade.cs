using System;

namespace GradebookApplication
{
    public class ThrowAwayLowestGrade : GradeBook
    {
        public override  GradeStatistics ComputeStatistics()
        {

            Console.WriteLine("Now let us remove the lowest grade from the gradebook");
            double lowest = double.MaxValue;
            foreach (var grade in grades)
            {
                lowest = Math.Min(grade, lowest);
            }
            Console.WriteLine($"The lowest grade is removed ,which is : {lowest}");
            grades.Remove(lowest);
            
            //calls the method by this name in the base class
            return base.ComputeStatistics();
        }
    }
}
