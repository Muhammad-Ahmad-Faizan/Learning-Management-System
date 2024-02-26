using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTrial.BusinessLayer
{
    class Attendance
    {
        public string AttendanceID { get; set; }
        public string IsPresent { get; set; }
        public DateTime LectureDate { get; set; }
        public Attendance(){ }
        public Attendance(string atid, string present, DateTime lecDate)
        {
            AttendanceID = atid;
            IsPresent = present;
            LectureDate = lecDate;
        }
        public Attendance(string atid, DateTime lecDate)
        {
            AttendanceID = atid;
            LectureDate = lecDate;
        }
        Student[] s = new Student[20];
        int index1 = 0;
        public void StudyCourses(Student std)
        {
            s[index1] = std;
            index1++;
        }
        public void ShowEnrollCourses()
        {
            foreach (Student std in s)
            {
                Console.WriteLine(std);
            }
        }

    }
}
