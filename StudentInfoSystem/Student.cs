using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentInfoSystem
{
    public class Student
    {
        [Key]
        [ForeignKey("User")]
        public Guid StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string LastName { get; set; }
        public string Faculty { get; set; }
        public string Specialty { get; set; }
        public string Degree { get; set; }
        public string Status { get; set; }
        public string FacultyNumber { get; set; }
        public int Course { get; set; }
        public int Flow { get; set; }
        public int Group { get; set; }
        public double Grade { get; set; }

        public virtual User User { get; set; }

        public Student()
        {

        }

        public Student(string Name, string Surname, string LastName, string Faculty, string Specialty, string Degree, string Status, string FacultyNumber, int Course, int Flow, int Group, double Grade)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.LastName = LastName;
            this.Faculty = Faculty;
            this.Specialty = Specialty;
            this.Degree = Degree;
            this.Status = Status;
            this.FacultyNumber = FacultyNumber;
            this.Course = Course;
            this.Flow = Flow;
            this.Group = Group;
            this.Grade = Grade;
        }

        public Student(Guid StudentId, string Name, string Surname, string LastName, string Faculty, string Specialty, string Degree, string Status, string FacultyNumber, int Course, int Flow, int Group, int Grade) 
            : this(Name, Surname, LastName, Faculty, Specialty, Degree, Status, FacultyNumber, Course, Flow, Group, Grade)
        {
            this.StudentId = StudentId;
        }
    }
}
