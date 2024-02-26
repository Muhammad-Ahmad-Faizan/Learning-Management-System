using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProjectTrial.BusinessLayer;
using ProjectTrial.Presentation;
using System.Globalization;

namespace ProjectTrial.DataLayer
{
    static class Connection
    {
        //Connection String
        public static SqlConnection MyConnection()
        {
            string ConString = "Data Source=DESKTOP-JMJ5G7T;Initial Catalog=ProjectLMS;Integrated Security=True";
            SqlConnection connect = new SqlConnection(ConString);
            connect.Open();
            return connect;
        }
        //Admin Portal Login
        public static SqlDataReader AdminPortal(string UserName, string password)
        {
            SqlConnection myconnection = MyConnection();
             string query = "Exec AdminLogin @userName = '"+UserName+"', @Password = '"+password+"'; ";
           SqlCommand cmd = new SqlCommand(query, myconnection);

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;

        }
        //Getting Teacher Table in AdminPortal
        public static DataTable GetTeacherTable()
        {
            string Query = TeacherQuery();
            SqlConnection myconnection = MyConnection();
            SqlCommand cmd = new SqlCommand(Query, myconnection);
            SqlDataAdapter myAdapter = new SqlDataAdapter(Query, myconnection);
            myAdapter.SelectCommand = cmd;
            myconnection.Close();
            DataTable T = new DataTable();
            myAdapter.Fill(T);
            return T;
        }
        public static string TeacherQuery()
        {
            string query = "Select * from Teacher";
            return query;
        }
        //Counting Teachers to show on Dashboard
        public static int CountTeacher()
        {


            int countTeacher = 0;

            using (SqlConnection myconnection = MyConnection())
            {

                string query = "SELECT COUNT(TID) FROM Teacher";
                SqlCommand cmd = new SqlCommand(query, myconnection);
                countTeacher = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return countTeacher;

        }
        //Adding Teacher
        public static void InsertTeacher(Teacher t)
        {
            SqlConnection myconnection = MyConnection();
           string query = "Insert into Teacher (TID, Name, CNIC, Gender, BloodGroup, Religion, Qualification, Designation, Phone, Email, Address, Password) values ('" + t.Id + "', ' " + t.name + "', '" + t.CNIC + "', '" + t.Gender + "', '" + t.BloodGroup + "', '" + t.Religion + "', '" + t.Qualification + "', '" + t.Designation + "', '" + t.Phone + "', '" + t.Email + "', '" + t.Address + "', '" + t.Password + "')";
         
            SqlCommand cmd = new SqlCommand(query, myconnection);
            cmd.ExecuteNonQuery();
            myconnection.Close();
        }
        //Assigning Course To Teacher
        public static void AssignCourse(string Tid, string cid)
        {
            SqlConnection myconnection = MyConnection();
            string query = "UPDATE Courses SET TID = '" + Tid + "' WHERE CID = '"+cid+"'; ";
            SqlCommand cmd = new SqlCommand(query, myconnection);
            cmd.ExecuteNonQuery();
            myconnection.Close();
        }
        public static SqlDataReader ShowAssignCourse(string cid)
        {
            SqlConnection myconnection = MyConnection();
            string query = "Select CourseTitle, CreditHour From Courses Where  CID = '" + cid + "';";
            SqlCommand cmd = new SqlCommand(query, myconnection);
            SqlDataReader myreader = cmd.ExecuteReader();
            return myreader;
        }
        //Updating teacher information
        public static void UpdateTeacher(Teacher t)
        {
            SqlConnection myconnection = MyConnection();
            string query = "update Teacher SET CNIC = '" + t.CNIC + "', Gender= '" + t.Gender + "',BloodGroup='" + t.BloodGroup + "',Religion= '" + t.Religion + "',Qualification='" + t.Qualification + "',Designation= '" + t.Designation + "',Phone= '" + t.Phone + "',Email= '" + t.Email + "',Address= '" + t.Address + "', Password='" + t.Password + "' where TID = '" + t.ID + "'";
            SqlCommand cmd = new SqlCommand(query, myconnection);
            cmd.ExecuteNonQuery();

               
        }
        //Deleting Teacher Record
        public static void DeleteTeacher(Teacher t)
        {
            SqlConnection myconnection = MyConnection();

            string query = "Delete Teacher where TID='" + t.ID + "'";
            SqlCommand cmd = new SqlCommand(query, myconnection);
            cmd.ExecuteNonQuery();


        }
        //Teacher Portal Login
        public static SqlDataReader TeacherPortal(string teacherID, string password)
        {
            SqlConnection myconnection = MyConnection();
            string query = "Exec TeacherLogin @TID = '"+teacherID+"',@Password = '"+password+"'; ";
            SqlCommand cmd = new SqlCommand(query, myconnection);

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;

        }

        //Counting Students for Showing in Admin Dashboard
        public static int CountStudent()
        {


            int countStd = 0;

            using (SqlConnection myconnection = MyConnection())
            {

                string query = "SELECT COUNT(RegNo) FROM Student";
                SqlCommand cmd = new SqlCommand(query, myconnection);
                countStd = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return countStd;

        }
        //Adding Student
        public static void InsertStudent(Student student)
        {
            SqlConnection myconnection = MyConnection();
            string query1 = "INSERT INTO Student (RegNo,Name,CNIC,Gender ,BloodGroup ,Religion ,Phone ,Email ,Address ,FatherName ,Contact ,Batch ,Department ,Specialization,Password ) VALUES('" + student.ID + "','" + student.Name + "','" + student.CNIC + "','" + student.Gender + "','" + student.BloodGroup + "','" + student.Religion + "','" + student.Phone + "','" + student.Email + "','" + student.Address + "','" + student.FatherName + "','" + student.Contact + "','" + student.Batch + "','" + student.Department + "','" + student.Specialization + "','" + student.Password + "')";
      
            SqlCommand cmd1 = new SqlCommand(query1, myconnection);

            cmd1.ExecuteNonQuery();
         
            myconnection.Close();
        }
        //Get Student Table in Admin Portal
        public static DataTable GetStudentTable()
        {
            string Query = "Select * from Student";
            SqlConnection myconnection = MyConnection();
            SqlCommand cmd = new SqlCommand(Query, myconnection);
            SqlDataAdapter myAdapter = new SqlDataAdapter(Query, myconnection);
            myAdapter.SelectCommand = cmd;
            myconnection.Close();
            DataTable T = new DataTable();
            myAdapter.Fill(T);
            return T;
        }
        //Updating Student Data
        public static void UpdateStudent(Student s)
        {
            SqlConnection myconnection = MyConnection();
            string query = "update Student SET CNIC = '" + s.CNIC + "', Gender= '" + s.Gender + "',BloodGroup='" + s.BloodGroup + "',Religion= '" + s.Religion + "',Phone= '" + s.Phone + "',Email= '" + s.Email + "',Address= '" + s.Address + "', Password='" + s.Password + "', FatherName = '" + s.FatherName + "', Contact = '" + s.Contact + "', Batch = '" + s.Batch + "', Department = '" + s.Department + "',Specialization = '" + s.Specialization + "'WHERE RegNo = '" + s.ID + "' ";
            SqlCommand cmd = new SqlCommand(query, myconnection);
            cmd.ExecuteNonQuery();


        }
        //Deleting Student Data
        public static void DeleteStudent(Student t)
        {
            SqlConnection myconnection = MyConnection();

            string query = "Delete Student where RegNo='" + t.ID + "'";
            SqlCommand cmd = new SqlCommand(query, myconnection);
            cmd.ExecuteNonQuery();


        }
        //Student Portal Login
        public static SqlDataReader StudentPortal(string RegNumber, string password)
        {
            SqlConnection myconnection = MyConnection();
            string query = "Exec StudentLogin @RegNo = '"+RegNumber+"', @Password = '"+password+"'; ";
            SqlCommand cmd = new SqlCommand(query, myconnection);

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;

        }
        public static SqlDataReader StudentHeaderDisplay(string RegNumber)
        {
            SqlConnection myconnection = MyConnection();
            string query = "SELECT Batch,Department,Specialization FROM Student WHERE RegNo= '" + RegNumber + "' ";

            SqlCommand cmd = new SqlCommand(query, myconnection);

            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }
        //Courses showing on Student Portal
        public static DataTable CoursesDisplaySP()
        {
            Courses c = new Courses();
            string Query = "select Courses.CID, Courses.CourseTitle, Courses.CreditHour, Teacher.Name from Courses inner join Teacher on Courses.TID =Teacher.TID Order by CID";
            SqlConnection myconnection = MyConnection();
            SqlCommand cmd = new SqlCommand(Query, myconnection);
            SqlDataAdapter myAdapter = new SqlDataAdapter(Query, myconnection);
            myAdapter.SelectCommand = cmd;
            myconnection.Close();
            DataTable T = new DataTable();
            myAdapter.Fill(T);
            return T;
        }
        //Course showing on Teacher portal
        public static SqlDataReader CourseDetailTP(string teacherID)
        {
            SqlConnection myConnection = MyConnection();
            string query = "Select c.CID,c.CourseTitle, c.CreditHour From Courses as c Join Teacher as t on c.TID = t.TID Where t.TID='" + teacherID + "'";
            SqlCommand cmd = new SqlCommand(query, myConnection);
            SqlDataReader myReader = cmd.ExecuteReader();
            return myReader;
        }
        //Showing lectures of specific course on Teacher portal
        public static SqlDataReader LectureTP(string teacherID)
        {
            Lectures lec = new Lectures();
            SqlConnection myConnection = MyConnection();
            string query = "select l.Lecture1, l.Lecture2, l.Lecture3, l.Lecture4, l.Lecture5 from Lectures l inner join Courses c on l.CID = c.CID inner join Teacher t on c.TID = t.TID where t.TID ='" + teacherID + "'";
            SqlCommand cmd = new SqlCommand(query, myConnection);
            SqlDataReader myReader = cmd.ExecuteReader();
            return myReader;
        }
        //Marking attendance by teacher
       public static DataTable MarkAttendance() { 
        string Query = "Select student.RegNo, Student.Name from Student Order By RegNo Asc";
            //join Courses on Student.RegNo=Courses.RegNo Where Courses.CID='"+courseId+"';" string courseId
            SqlConnection myconnection = MyConnection();
        SqlCommand cmd = new SqlCommand(Query, myconnection);
        SqlDataAdapter myAdapter = new SqlDataAdapter(Query, myconnection);
        myAdapter.SelectCommand = cmd;
            myconnection.Close();
            DataTable T = new DataTable();
        myAdapter.Fill(T);
            return T;
            } 
        //Showing attendance Detail on Student Portal
        public static DataTable Attendance(string attendance, string regNo, string atid, string courseId)
        {
            Attendance a = new Attendance();
            string Query = "UPDATE Attendance " +
                  "SET IsPresent = '" + attendance + "' " +
                  "WHERE Attendance.RegNo = '" + regNo + "' " +
                  "AND Attendance.AttendanceID = '" + atid + "' " +
                  "AND Attendance.LID IN (SELECT Lectures.LID " +
                                        "FROM Lectures " +
                                        "INNER JOIN Courses ON Lectures.CID = Courses.CID " +
                                        "WHERE Courses.CID = '" + courseId + "')";


            SqlConnection myconnection = MyConnection();
            SqlCommand cmd = new SqlCommand(Query, myconnection);
            SqlDataAdapter myAdapter = new SqlDataAdapter(Query, myconnection);
            myAdapter.SelectCommand = cmd;
            myconnection.Close();
            DataTable T = new DataTable();
            myAdapter.Fill(T);
            return T;
        }
        public static DataTable AttendanceStatus(string atid)
        {
            string Query = "select IsPresent from Attendance where AttendanceID = '"+atid+"' order by RegNo";


            SqlConnection myconnection = MyConnection();
            SqlCommand cmd = new SqlCommand(Query, myconnection);
            SqlDataAdapter myAdapter = new SqlDataAdapter(Query, myconnection);
            myAdapter.SelectCommand = cmd;
           
            DataTable T = new DataTable();
            myAdapter.Fill(T);
            return T;
        }
     
        public static void AttendanceDate(Attendance a)
        {
            string Query = "UPDATE Attendance SET AttendanceDate = @LectureDate WHERE AttendanceID = @AttendanceID";

            using (SqlConnection myconnection = MyConnection())
            {
                using (SqlCommand cmd = new SqlCommand(Query, myconnection))
                {
                    // Assuming LectureDate is a DateTime variable in your Attendance class
                    cmd.Parameters.AddWithValue("@LectureDate", a.LectureDate);

                    // Assuming AttendanceID is a string variable in your Attendance class
                    cmd.Parameters.AddWithValue("@AttendanceID", a.AttendanceID);

                    cmd.ExecuteNonQuery();
                    myconnection.Close();
                }
            }
        }

        public static SqlDataReader countAttendance(string regNo, string cid)
        {
            SqlConnection myconnection = MyConnection();
            string query = "SELECT COUNT(IsPresent) AS TotalPresent FROM Attendance WHERE RegNo ='"+regNo+"'  AND Attendance.LID in (select LID from Lectures join Courses on Lectures.CID = Courses.CID  Where Courses.CID = '"+cid+"') AND IsPresent = 'Present';";
            SqlCommand cmd = new SqlCommand(query, myconnection);
            SqlDataReader myReader = cmd.ExecuteReader();
            return myReader;
        
    }
        

    }
}
