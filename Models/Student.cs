using System;
using System.Collections.Generic;

namespace ITSA_Assessment.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
