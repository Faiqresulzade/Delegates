﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Delegates
{
    class Student:Human
    {
        public int? Grade { get; set; }
         
        public Student() : base()
        {
           

        }
        public Student(string name,string surname,int age,int grade) : base(name, surname, age)
        {
            Grade = grade;
        }
    }
}
