using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class Student
    {
       public String? StudentId { get; set; }
       public String? StudentName { get; set; }
        public override string ToString()//ToString()指定成字串
        {
            return $"{StudentId} {StudentName}";

        }
    }
}
