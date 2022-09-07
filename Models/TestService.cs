namespace NetProgPractices.Models
{
    public class TestService : ITestService 
    {

        public Student getStudent ()
        {

            Student newStudent = new();

            newStudent = new Student { IdStudent = 1, StudentName = "Primer Alumno" };

            return newStudent;

        }

        public string getStudentName(int id)
        {
            return "Carlos Cristóbal";
        }

    }

    public class Student
    {
        public int IdStudent { get; set; }

        public string?  StudentName { get; set; }
    }

}
