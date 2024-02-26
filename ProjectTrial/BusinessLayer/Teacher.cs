using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTrial.BusinessLayer
{
    class Teacher:User,IPerson
    {
        public string Qualification { get; set; }
        public string Designation { get; set; }
        public string Id;
        public string name;
        public string ID { get { return Id; } set { Id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public Teacher()
        {

        }
        public Teacher(string qual, string desig,string id, string nam,  int cnic, string gender, string blood, string religion, string phone, string email, string add, string pswd):base( cnic,  gender,  blood,  religion,  phone,  email,  add, pswd) 
        {
            ID = id;
            Name = nam;
            Qualification = qual;
            Designation = desig;
        }
    }
}
