using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentInfoSystem
{
    static class StudentData
    {
        static private List<Student> _TestStudents;

        static public List<Student> GetTestStudents()
        {
            ResetStudentData();
            return _TestStudents;
        }

        static private void ResetStudentData()
        {
            _TestStudents = new List<Student>
            {
                new Student("Stoyan", "Angelov", "Iliev", "FKST", "KSI", DegreeType.MASTER, StudentStatus.CERTIFIED, "121218055", 5, 10, 37, 6),
                new Student("Atanas", "Stoyanov", "Ivanov", "FKST", "KSI", DegreeType.BACHELOR, StudentStatus.CERTIFIED, "121218056", 3, 9, 50, 4.5),
                new Student("Angel", "Milanov", "Iliev", "FKST", "ITI", DegreeType.PROFFESIONAL_BACHELOR, StudentStatus.CERTIFIED, "121218220", 4, 12, 69, 4)
            };
        }

        public static Student GetStudentByFaculty(string facultyNumber)
        {
            if (String.IsNullOrEmpty(facultyNumber))
            {
                throw new ArgumentException("Не е въведен факултетен номер!");
            }

            StudentInfoContext context = new StudentInfoContext();

            Student result =
                (from st in context.Students
                where st.FacultyNumber == facultyNumber
                select st).First();
                return result;
        }
    }
}
