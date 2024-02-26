using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTrial.BusinessLayer
{
    class Admin:IPerson
    {
        public string Id;
        public string name;
        public string ID { get { return Id; } set { Id = value; } }
        public string Name { get { return name; } set { name = value; } }

        Student[] s = new Student[20];
        int index1 = 0;
        public void Managestudents(Student std)
        {
            s[index1] = std;
            index1++;
        }
        public void ShowListOfStudents()
        {
            foreach (Student std in s)
            {
                Console.WriteLine(std);
            }
        }
        Teacher[] t = new Teacher[20];
        int index2 = 0;
        public void ManageTeachers(Teacher tch)
        {
            t[index2] = tch;
            index2++;
        }
        public void ShowListOfTeachers()
        {
            foreach (Teacher tch in t)
            {
                Console.WriteLine(tch);
            }
        }
    }
}
