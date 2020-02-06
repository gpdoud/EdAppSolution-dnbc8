using System;
using System.Collections.Generic;
using System.Text;

namespace EdAppProject {
    class Student {

        public int Id;
        public string Firstname;
        public string Lastname;
        public int SAT;
        public double GPA;
        public int MajorId;

        public Student(int id, string firstname, string lastname, int sat, double gpa, int majorid) {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            SAT = sat;
            GPA = gpa;
            MajorId = majorid;
        }

        public void Print() {
            Console.WriteLine($"Id={Id}, Name={Firstname} {Lastname}, SAT={SAT}, GPA={GPA}, MajorId={MajorId}");
        }
    }
}
