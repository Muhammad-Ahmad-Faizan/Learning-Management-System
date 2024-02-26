using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTrial.BusinessLayer
{
    class Courses
    {
        public string CID { get; set; }
        public string CourseTitle { get; set; }
        public int CreditHours { get; set; }
        public Lectures[] lectures;
     public Courses()
        {

        }
        public Courses(string cid, string courseTitle, int creditHour)
        {
            CID = cid;
            CourseTitle = courseTitle;
            CreditHours = creditHour;
            lectures = new Lectures[5];
            
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
        Teacher[] t = new Teacher[20];
        int index2 = 0;
        public void TeachCourses(Teacher tch)
        {
            t[index2] = tch;
            index2++;
        }
        public void ShowTeachers()
        {
            foreach (Teacher tch in t)
            {
                Console.WriteLine(tch);
            }
        }

    }
}
