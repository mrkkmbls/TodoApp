namespace TodoApp.Models
{
    public class Student
    {
        public int studentId { get; set; }

        public string studentName { get; set; }

        public int studentAge { get; set; }

        public string studentAddress { get; set; }

        public Student()
        {
        }

        public Student(int studentId, string studentName, int studentAge, string studentAddress)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.studentAge = studentAge;
            this.studentAddress = studentAddress;
        }
    }
}
