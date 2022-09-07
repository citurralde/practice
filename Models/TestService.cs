namespace NetProgPractices.Models
{
    public class TestService
    {

        public Student getStudent ()
        {

            Student newStudent = new();

            newStudent = new Student { IdStudent = 1, StudentName = "Primer Alumno" };

            return newStudent;

        }

    }

    public class Student
    {
        public int IdStudent { get; set; }

        public string?  StudentName { get; set; }
    }

}
