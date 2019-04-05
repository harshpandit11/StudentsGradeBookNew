using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradebookApplication
{
    public class NameChangedEventArgs:EventArgs
    {
        public string existingname { get; set; }
        public string newname { get; set; }
    }
}
