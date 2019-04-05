using GradebookApplication;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGradeBookAppCTC
{
    public abstract class GradeTracker:IGradeTracker
    {
        public abstract void AddGrade(double grade);
        public abstract GradeStatistics ComputeStatistics();
        public abstract void WriteGrades(StreamWriter destination);
        public abstract IEnumerator GetEnumerator();

       
        protected string _name;
        public string Name
        {
            get
            {
                _name = _name.ToUpper();
                return _name;
            }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("Name cannot be null or empty");
                    }
                    if (_name != value && NameChanged != null)
                    {

                        //create an instance of the eventargs class to store the arguments and the information they contain
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.existingname = _name;
                        args.newname = value;
                        //invoked the event  when name is changed
                        NameChanged(this, args);
                    }
                    _name = value;

                }


                catch (ArgumentNullException ex)
                {

                    Console.WriteLine(ex.InnerException.ToString(), "The input value cannot be null");
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(e.InnerException.ToString(), "Cannot pass null value to object");
                }
                catch (Exception excep)
                {
                    Console.WriteLine(excep);
                }

            }
        }
        //created a variable of the type of the delegate defined in another class file.
        //This is event whose type is of the delegate which is defined
        public event NameChangedDelegate NameChanged;


    }
}
