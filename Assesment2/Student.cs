using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assesment2
{
    internal class Student : Person
    {
        public int StudentId { get; set; }
        public string Program { get; set; }
        public DateTime DateRegistered { get; set; }
        public Address StudentAddress { get; set; }
        public List<Enrollment> Enrollments { get; set; }

        public Student(int studentId, string name, string email, string telNum, string program, DateTime dateRegistered)
            : base(name, email, telNum)
        {
            StudentId = studentId;
            Program = program;
            DateRegistered = dateRegistered;
            Enrollments = new List<Enrollment>();
        }

        // Method to add an enrollment to the student
        public void AddEnrollment(Enrollment enrollment)
        {
            Enrollments.Add(enrollment);
        }

        // Method to display student details
        public override string ToString()
        {
            string studentDetails = $"Student ID: {StudentId}\nProgram: {Program}\nDate Registered: {DateRegistered.ToShortDateString()}";
            string addressDetails = StudentAddress != null ? $"Address: {StudentAddress}" : "No address available";
            string enrollmentDetails = Enrollments.Any() ? $"Enrollments: {Enrollments.Count}" : "No enrollments available";

            return $"{base.ToString()}\n{studentDetails}\n{addressDetails}\n{enrollmentDetails}";
        }


        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + StudentId.GetHashCode();
                hash = hash * 23 + (Program?.GetHashCode() ?? 0);
                return hash;
            }
        }

    }
}
