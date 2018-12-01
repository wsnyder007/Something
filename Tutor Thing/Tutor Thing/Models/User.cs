using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Project_Tutor.Model {
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