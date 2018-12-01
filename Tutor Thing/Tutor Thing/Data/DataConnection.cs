using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Project_Tutor.Model;

namespace Project_Tutor.Data {
    class DataConnection {
        private static SqlConnection NewCon;
        private static string conStr = "";// ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;  
        
        public static SqlConnection getConnection() {
            NewCon = new SqlConnection(conStr);
            return NewCon;
        }
        public void DBConnect() {
                
        }

        public static User Login(string username, string password) {
            return new User(1, "John", "Smith", "10AM to 2PM", "Hi", false, new List<int>() { 1, 2, 3, 4 });
        }
            
        public static List<Course> GetUserCourses(int userId) {
            List<Course> courses = new List<Course>();
            courses.Add(new Course(1, "CSC 100", "Computer Science", new List<int>() { 1 }));
            courses.Add(new Course(2, "CSC 101", "Also Computer Science", new List<int>() { 1 }));
            courses.Add(new Course(3, "CSC 220", "Foundations of Computer Science", new List<int>() { 1 }));
            courses.Add(new Course(4, "CSC 402", "More Computer Science", new List<int>() { 1 }));
            return courses;
        }
    }
}
