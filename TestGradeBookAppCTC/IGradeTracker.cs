using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace GradebookApplication
{
    internal interface IGradeTracker :IEnumerable
    {
        void AddGrade(double grade);
        GradeStatistics ComputeStatistics();
        void WriteGrades(StreamWriter destination);
        string Name { get; set; }
        //IEnumerable GetEnumerator();
    }
}