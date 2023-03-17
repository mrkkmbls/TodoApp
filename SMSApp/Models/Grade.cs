namespace SMSApp.Models
{
    public class Grade
    {
        public int gradeId { get; set; }

        public string gradeName { get; set;}

        //public int StudentId { get; set; }

        //public Student Student { get; set; }

        public Grade()
        {
        }

        public Grade(int gradeId, string gradeName)
        {
            this.gradeId = gradeId;
            this.gradeName = gradeName;
        }
    }
}
