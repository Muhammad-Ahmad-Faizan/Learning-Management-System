using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTrial.BusinessLayer
{
    class Lectures
    {
        public string LecId { get; set; }
        public string Lec1 { get; set; }
        public string Lec2 { get; set; }
        public string Lec3 { get; set; }
        public string Lec4 { get; set; }
        public string Lec5 { get; set; }
        public Attendance[] attendance;
        public Lectures()
        {

        }
        public Lectures(string lid, string lec1, string lec2, string lec3, string lec4, string lec5, Attendance[] a)
        {
            LecId = lid;
            Lec1 = lec1;
            Lec2 = lec2;
            Lec3 = lec3;
            Lec4 = lec4;
            Lec5 = lec5;
            attendance = new Attendance[50];
            attendance = a;
        }
    }
}
