using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
     public  class Student
    {
        string id;
        string name;
        string age;
        string sex;
        string address;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Age { get => age; set => age = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Address { get => address; set => address = value; }
    }
}
