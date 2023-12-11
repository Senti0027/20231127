using System;

namespace WpfApp2
{
    internal class Course
    {
     public String? CourseName { get; set; }
        public String? Type { get; set; }
        public int Point { get; set; }
        public String? OpeningClass { get; set; }

        Teacher? Tutor { get; set; }
        public Course(Teacher totur) {
            Tutor=totur;
        }
    }
}
