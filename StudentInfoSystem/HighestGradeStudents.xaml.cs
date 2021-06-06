using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for HighestGradeStudents.xaml
    /// </summary>
    public partial class HighestGradeStudents : Window
    {
        public HighestGradeStudents()
        {
            InitializeComponent();
        }

        private void OnClick_Show(object sender, RoutedEventArgs e)
        {
            listResultStudents.Items.Clear();
            int.TryParse(txtStudentNumberLimit.Text, out int limitStudents);

            using StudentInfoContext context = new StudentInfoContext();
            List<Student> studentsWithHighestGrade = context
                .Students
                .OrderByDescending(s => s.Grade)
                .Take(limitStudents)
                .ToList();

            studentsWithHighestGrade.ForEach(s => listResultStudents.Items.Add(s));
        }
    }
}
