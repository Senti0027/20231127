﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students=new List<Student>();
        Student selectedStudent = null;

        List<Course> courses = new List<Course>();
        Course selectedCourse = null;

        List<Teacher> teachers = new List<Teacher>();
        Teacher selectedTeacher = null;

        public MainWindow()
        {
            InitializeComponent();
            InitializeStudent();
            InititalizeCourse();

        }

        private void InititalizeCourse()
        {
            Teacher teacher1 = new Teacher
            {
                TeacherName="陳定宏"
            };
            teacher1.TeachingCourses.Add(new Course(teacher1) {CourseName = "視窗程式設計", OpeningClass = "五專資工三甲",Type = "必修", Point = 3 });
            teacher1.TeachingCourses.Add(new Course(teacher1) { CourseName = "視窗程式設計", OpeningClass = "四技二甲", Point = 3, Type = "選修" });
            teacher1.TeachingCourses.Add(new Course(teacher1) { CourseName = "視窗程式設計", OpeningClass = "四技二乙", Point = 3, Type = "選修" });
            teacher1.TeachingCourses.Add(new Course(teacher1) { CourseName = "視窗程式設計", OpeningClass = "四技二丙", Point = 3, Type = "選修" });

            Teacher teacher2 = new Teacher() 
            { 
                TeacherName = "陳福坤"
            };
            teacher2.TeachingCourses.Add(new Course(teacher2) { CourseName = "計算機概論",OpeningClass = "四技一丙", Point = 2, Type = "必修" });
            teacher2.TeachingCourses.Add(new Course(teacher2) { CourseName = "計算機概論", OpeningClass = "四技一丙", Point = 2, Type = "必修" });
            teacher2.TeachingCourses.Add(new Course(teacher2) { CourseName = "計算機概論", OpeningClass = "四技一甲一乙", Point = 2, Type = "必修" });
            teacher2.TeachingCourses.Add(new Course(teacher2) { CourseName = "數位系統導論", OpeningClass = "四技一乙", Point = 3, Type = "必修" });

            Teacher teacher3 = new Teacher()
            { 
                TeacherName = "許子衡"
            };
            teacher3.TeachingCourses.Add(new Course(teacher3) { CourseName = "Android程式設計", OpeningClass = "四技資工三甲等合開",Point = 3, Type = "選修"});
            teacher3.TeachingCourses.Add(new Course(teacher3) { CourseName = "人工智慧與雲端運算", OpeningClass = "四技資工四甲等合開", Point = 3, Type = "選修" });
            teacher3.TeachingCourses.Add(new Course(teacher3) { CourseName = "動態程式語言", OpeningClass = "五專資工三甲", Point = 3, Type = "系定選修" });
            
            teachers.Add(teacher1);
            teachers.Add(teacher2);
            teachers.Add(teacher3);
            tvTeacher.ItemsSource = teachers;
            foreach (Teacher teacher in teachers)
            {
                foreach (Course course in teacher.TeachingCourses)
                {
                    courses.Add(course);
                }
            }
            lbCourse.ItemsSource = courses;
        }

        private void InitializeStudent()
        {
            students.Add(new Student { StudentId = "A1234567", StudentName = "陳小明" });
            students.Add(new Student { StudentId = "A1234678", StudentName = "王小美" });
            students.Add(new Student { StudentId = "A1234789", StudentName = "林小英" });

            /*foreach (Student student in students)
            {
                cmbStudent.Items.Add(student);//另一種方法Another way
            }*/

            cmbStudent.ItemsSource = students;

            cmbStudent.SelectedIndex = 0;
        }
       

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cmbStudent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedStudent=(Student)cmbStudent.SelectedItem;
            LabelStatus.Content = $"選取學生:{selectedStudent.ToString()}";
        }

        private void lbCourse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
