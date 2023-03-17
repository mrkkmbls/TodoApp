using System.Reflection.Metadata.Ecma335;

namespace SMSApp.Models
{
    public class Student
    {
        public int studentId { get; set; }

        public string studentName { get; set; }

        public int studentAge { get; set; }

        //public string studentAddress { get; set; }

        public string studentEmailId { get; set; }

        //field is used on database level for relationship
        //public int GradeId { set; get; } //id of object
        //object is used in application level
        public Grade Grade { get; set; } //object

        public List<Course> Courses { get; set; }


        public Student()
        {
        }

        public Student(int studentId, string studentName, int studentAge, string studentAddress, string studentEmailId)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.studentAge = studentAge;
            //this.studentAddress = studentAddress;
            this.studentEmailId = studentEmailId;
        }
    }
}
