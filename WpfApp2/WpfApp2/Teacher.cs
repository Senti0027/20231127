using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class Teacher
    {
        public String? TeacherName { get; set; }
        public ObservableCollection<Course> TeachingCourses { get; set; }=
        new ObservableCollection<Course>();//在更動集合中的項目時發出通知

        public override string ToString()
        {
            return $"{TeacherName}";
        }
    }
}
