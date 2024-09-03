using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_20
{
    class Student
    {
        string firstName;
        string lastName;
        string phoneNumber;
        string email;
        string studentID;

        public Student(string firstName, string lastName, string phoneNumber, string email, string studentID)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            StudentID = studentID;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string StudentID { get => studentID; set => studentID = value; }
    }
}
