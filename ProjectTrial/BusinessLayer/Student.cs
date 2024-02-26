using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTrial.BusinessLayer
{
    class Student:User,IPerson
    {
        public string FatherName { get; set; }
        public string Contact { get; set; }
        public string Batch { get; set; }
        public string Department { get; set; }
        public string Specialization { get; set; }

        public string Id;
        public string name;
        public string ID { get { return Id; } set { Id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public Student()
        {

        }
        public Student(string RegNo, string nam, string FatherName, string Contact, string Batch,  string Department, string Specialization,  int cnic, string gender, string blood, string religion, string phone, string email, string add, string pswd) : base( cnic, gender, blood, religion, phone, email, add, pswd)
        {
            this.Name = nam;
            this.FatherName = FatherName;
            this.ID = RegNo; 
            this.Contact = Contact;
            this.Batch = Batch;
            this.Department = Department;
            this.Specialization = Specialization;
         }
        Courses[] c = new Courses[7];
        int index = 0;
        public void StudyCourses(Courses cos)
        {
            c[index] = cos;
            index++;
        }
        public void ShowEnrollCourses()
        {
            foreach (Courses cs in c)
            {
                Console.WriteLine(cs);
            }
        }
    }
}
