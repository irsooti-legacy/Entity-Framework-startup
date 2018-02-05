using System;
using System.Collections.Generic;

namespace EfScaffoldingProject.Entities
{
    // The Student Entity Class
    ///////////////////////////
    public class Student
    {
        public int ID { get; set; }  //this is the primary key of the Student table
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //Enrollments is a navigation property to gold enrollment data found in an other table
        public ICollection<Enrollment> Enrollments { get; set; }
    }

}