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

namespace Harjoitus_20
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Köytetty chatgpt apuna
    public partial class MainWindow : Window
    {
        List<Student> Students = new List<Student>();

        public MainWindow()
        {
            InitializeComponent();

            dg_Students.ItemsSource = Students;
        }

        private void btn_AddStudent_Click(object sender, RoutedEventArgs e)
        {
            string firstName = Input_FirstName.Text;
            string lastName = Input_LastName.Text;
            string phoneNumber = Input_PhoneNumber.Text;
            string email = Input_Email.Text;
            string studentID = Input_StudentID.Text;

            Students.Add(new Student(firstName, lastName, phoneNumber, email, studentID));
            dg_Students.ItemsSource = Students;

            Input_FirstName.Text = "";
            Input_LastName.Text = "";
            Input_PhoneNumber.Text = "";
            Input_Email.Text = "";
            Input_StudentID.Text = "";
        }
    }
}
