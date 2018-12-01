using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Tutor.Models {
    public class Course {
        public int Id;
        public string Number;
        public string Name;
        public List<int> Attendees;

        public Course(int id, string number, string name, List<int> attendees) {
            Id = id;
            Number = number;
            Name = name;
            Attendees = attendees;
        }
    }
}