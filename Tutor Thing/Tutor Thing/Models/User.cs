using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Tutor.Models {
    public class User {
        public int Id;        
        public string FirstName;
        public string LastName;
        public string Availability;
        public string Bio;
        public bool IsTutor;
        public List<int> Courses;

        public User(int id, string firstName, string lastName, string availability, string bio, bool isTutor, List<int> courses) {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Availability = availability;
            Bio = bio;
            IsTutor = isTutor;
            Courses = courses;
        }
    }
}