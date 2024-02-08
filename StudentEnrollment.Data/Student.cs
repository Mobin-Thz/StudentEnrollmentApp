namespace StudentEnrollment.Data
{
    public class Student : BaseEntity
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public DateTime dateOfBirth { get; set; }

        public string idNumber { get; set; }

        public string picture { get; set; }

    }
}
