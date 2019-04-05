using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;
using System.Speech.Synthesis;
using System.IO;
using TestGradeBookAppCTC;

namespace GradebookApplication
{
    class Program
    {
 
        static void Main(string[] args)
        {
            IGradeTracker gradebookobj = CreateGradeBoook();
            //GetGradebookName
            GetBookName(gradebookobj);
            //CreateGradeBookAndAddGrades
            CreateGradeBookAndAddGrades(gradebookobj);
            //WriteGradesToFile
            WriteGradesToFile(gradebookobj);
            //Removal or hiding of the lowest grade
            // RemoveLowestGrade(gradebookobjlowest);
            //ComputeGrades
            ComputeGrades(gradebookobj);

        }

        private static IGradeTracker CreateGradeBoook()
        {

            return new ThrowAwayLowestGrade();
        }

        private static void ComputeGrades(IGradeTracker gradebookobj)
        {
            /*double is a 64 bit IEEE 754 double precision Floating Point Number (1 bit for the sign, 11 bits for the exponent, 
             and 52* bits for the value), i.e. double has 15 decimal digits of precision.*/
            /*A 32-bit float has about 7 digits of precision and a 64-bit double has about 16 digits of precision*/
            //SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            //speechSynthesizer.Speak("Name of my Book is MYLIFEMYSTORY");
            foreach (var grade in gradebookobj)
            {
                Console.WriteLine(grade);
            }
            
            GradeStatistics gradesOfStudents = gradebookobj.ComputeStatistics();
            Console.WriteLine("Now let us calculate some statistics like the highest,lowest and average grades:\n");
            /*In this case both the objs of gradebook will point to the same memory location on heap
             */
            WriteTheResultToConsole("The Average Marks are", gradesOfStudents.AverageGrade);
            WriteTheResultToConsole("So the grade is", gradesOfStudents.LetterGrade);
            WriteTheResultToConsole("The Highest marks scored are", Convert.ToInt64(gradesOfStudents.HighestGrade));
            WriteTheResultToConsole("The aggregate marks are", gradesOfStudents.Aggregate);
            WriteTheResultToConsole("The Lowest Marks scored are", gradesOfStudents.LowestGrade);
            
            Console.ReadLine();
        }

        private static IGradeTracker WriteGradesToFile(IGradeTracker gradebookobj)
        {
            //created a file to write the grades to
            //using streamwriter object and createtext method of FIle class
            using (StreamWriter fileobj = File.CreateText("grades.txt"))
            {
                gradebookobj.WriteGrades(fileobj);
            }
            return gradebookobj;
        }

        private static IGradeTracker CreateGradeBookAndAddGrades(IGradeTracker gradebookobj)
        {
            Console.WriteLine("\nEnter grades in the gradebook.Press END key to stop entering grades:");
            while(true)
                
            {
                double f1;
                var result = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(result))
                {
                    var conversionresult = double.TryParse(result, out f1);
                    gradebookobj.AddGrade(f1);
                }
                else
                {
                    break;
                }

            }

            return gradebookobj;

        }

        private static void GetBookName(IGradeTracker book)
        {
            var gradebookobj = new GradeBook();
            Console.WriteLine("Enter the Students Grade Bookname:\n");
            var NameOfTheBookEntered = Console.ReadLine();
            /*gradebookobj.Name = null;
            invoking the delegate on changing of name
            gradebook object calling namechangedevent +=calling a method which does the job of doing the required actions on change of name
            in this case OnNameChnaged. Remember - delegates is the base.
            */
            gradebookobj.NameChanged += OnNameChanged;
            gradebookobj.Name = NameOfTheBookEntered;
 
        }



        //Example of method overloading - samename,same no of parameters but one of them has diff datatype
        private static void WriteTheResultToConsole(string v1,double results,string resultdescription)
        {
            Console.WriteLine("{0}:{1}",v1,results);

        }
        private static void WriteTheResultToConsole(string v1, double results)
        {
           // Console.WriteLine("{0}:{1:F}", v1, results);
            //usage of string interpolation operator 
            Console.WriteLine($"{v1} : {results:F3}");
        }

        private static void WriteTheResultToConsole(string v1, string results)
        {
            Console.WriteLine($"{v1}:{results}", v1, results);

        }

        //Method to call when Name is changed from the default "EMPTY" to something else
        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"\nGradebook Name changed from {args.existingname} to {args.newname}");


        }

    }
}
