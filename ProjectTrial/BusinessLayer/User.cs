using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTrial.BusinessLayer
{
    class User
    {
        //public string ID { get; set; }
        //public string Name { get; set; }
        public int CNIC { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string Religion { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
      
        public User()
        {

        }
        public User( int cnic, string gender, string blood, string religion, string phone, string email, string add, string pswd)
        {
            //ID = id;
            //Name = name; string id, string name,
            CNIC = cnic;
            Gender = gender;
            BloodGroup = blood;
            Religion = religion;
            Phone = phone;
            Email = email;
            Address = add;
            Password = pswd;

        }
    }
}
