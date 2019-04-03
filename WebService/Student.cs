using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class Student
    {
        private List<Subject> subjects = new List<Subject>();
        private string name;
        private string surname;
        private int dni;

        public List<Subject> Subjects { get => subjects; set => subjects = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Dni { get => dni; set => dni = value; }

        public Student(){

        }
        public Student(List<Subject> Subjects, string Name, string Surname, int DNI){
            this.Subjects = Subjects;
            this.Name = Name;
            this.Surname = Surname;
            this.Dni = DNI;
        } 
        
}
}