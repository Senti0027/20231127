using System;
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
    }
}
