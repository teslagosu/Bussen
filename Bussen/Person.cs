using System;
using System.Collections.Generic;
using System.Text;

namespace Bussen
{
    class Person
    {
        private string name;
        private int age;
        private string profession;

        public Person(string name, int age, string profession)
        {
            this.name = name;
            this.age = age;
            this.profession = profession;
        }

        public Person()
        {
            this.name = "";
            this.age = 0;
            this.profession = "";
        }

        //getters and setters
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Profession { get => profession; set => profession = value; }
    }
}
