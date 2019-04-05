using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradebookApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests_GradeBookApp
{
    [TestClass]
    public class GradeBookTestsClass
    {
        [TestMethod]
        public void ValidateLetterGradeA()
        {
            var gradebookobj = new GradeBook();
            gradebookobj.AddGrade(80);
            gradebookobj.AddGrade(99);
            gradebookobj.AddGrade(95);
            GradeStatistics statsresult = gradebookobj.ComputeStatistics();
            Assert.AreEqual("A", statsresult.LetterGrade);
            

        }
        [TestMethod]
        public void ValidateLetterGradeAMarksgreaterthan100()
        {
            var gradebookobj = new GradeBook();
            gradebookobj.AddGrade(101);
            gradebookobj.AddGrade(99);
            gradebookobj.AddGrade(100);
            GradeStatistics statsresult = gradebookobj.ComputeStatistics();
            Assert.AreEqual("A", statsresult.LetterGrade);


        }
        [TestMethod]
        public void ValidateLetterGradeB()
        {
            var gradebookobj = new GradeBook();
            gradebookobj.AddGrade(80);
            gradebookobj.AddGrade(85);
            gradebookobj.AddGrade(86);
            GradeStatistics statsresult = gradebookobj.ComputeStatistics();
            Assert.AreEqual("B", statsresult.LetterGrade);
        }
        [TestMethod]
        public void ValidateLetterGradeC()
        {
            var gradebookobj = new GradeBook();
            gradebookobj.AddGrade(60);
            gradebookobj.AddGrade(65);
            gradebookobj.AddGrade(67);
            GradeStatistics statsresult = gradebookobj.ComputeStatistics();
            Assert.AreEqual("C", statsresult.LetterGrade);
        }
        [TestMethod]
        public void ValidateLetterGradeCEdgeCase()
        {
            var gradebookobj = new GradeBook();
            gradebookobj.AddGrade(79);
            gradebookobj.AddGrade(79);
            gradebookobj.AddGrade(79);
            GradeStatistics statsresult = gradebookobj.ComputeStatistics();
            Assert.AreEqual("C", statsresult.LetterGrade);
        }
        [TestMethod]
        public void ValidateLetterGradeD()
        {
            var gradebookobj = new GradeBook();
            gradebookobj.AddGrade(40);
            gradebookobj.AddGrade(45);
            gradebookobj.AddGrade(47);
            GradeStatistics statsresult = gradebookobj.ComputeStatistics();
            Assert.AreEqual("D", statsresult.LetterGrade);
        }
        [TestMethod]
        public void ValidateLetterGradeDEdgeCase()
        {
            var gradebookobj = new GradeBook();
            gradebookobj.AddGrade(59);
            gradebookobj.AddGrade(59);
            gradebookobj.AddGrade(59);
            GradeStatistics statsresult = gradebookobj.ComputeStatistics();
            Assert.AreEqual("D", statsresult.LetterGrade);
        }
        [TestMethod]
        public void ValidateLetterGradeF()
        {
            var gradebookobj = new GradeBook();
            gradebookobj.AddGrade(34);
            gradebookobj.AddGrade(30);
            gradebookobj.AddGrade(39);
            GradeStatistics statsresult = gradebookobj.ComputeStatistics();
            Assert.AreEqual("F", statsresult.LetterGrade);
        }
        [TestMethod]
        public void ValidateLetterGradeFEdgeCase()
        {
            var gradebookobj = new GradeBook();
            gradebookobj.AddGrade(39);
            gradebookobj.AddGrade(39);
            gradebookobj.AddGrade(39);
            GradeStatistics statsresult = gradebookobj.ComputeStatistics();
            Assert.AreEqual("F", statsresult.LetterGrade);
        }
        [TestMethod]
        public void ValidateLetterGradeFEdgeCase2()
        {
            var gradebookobj = new GradeBook();
            gradebookobj.AddGrade(0);
            gradebookobj.AddGrade(19);
            gradebookobj.AddGrade(10);
            GradeStatistics statsresult = gradebookobj.ComputeStatistics();
            Assert.AreEqual("F", statsresult.LetterGrade);
        }
        [TestMethod]
        

        public void ValidateComputeStatisticsForHighestGrade()
        {
            
            GradeBook gradunitobj = new GradeBook();
            gradunitobj.AddGrade(90);
            gradunitobj.AddGrade(36);
            GradeStatistics statsresult = gradunitobj.ComputeStatistics();
            Assert.AreEqual(90, statsresult.HighestGrade);

        }
        [TestMethod]
        public void ValidateComputeStatisticsForAverageGrade()
        {
            GradeBook gradunitobj = new GradeBook();
            gradunitobj.AddGrade(90);
            gradunitobj.AddGrade(36);
            GradeStatistics statsresult = gradunitobj.ComputeStatistics();
            Assert.AreEqual(63, statsresult.AverageGrade);

        }
        [TestMethod]
        public void ValidateComputeStatisticsForLowestGrade()
        {
            GradeBook gradunitobj = new GradeBook();
            gradunitobj.AddGrade(90);
            gradunitobj.AddGrade(36);
            GradeStatistics statsresult = gradunitobj.ComputeStatistics();
            Assert.AreEqual(36, statsresult.LowestGrade);

        }
    }

   

  
}
