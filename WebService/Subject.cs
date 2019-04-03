using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebService
{
    public class Subject
    {
        private string name;
        private int time;
        private int credits;
        private int idSubject;

        public string Name { get => name; set => name = value; }
        public int Time { get => time; set => time = value; }
        public int Credits { get => credits; set => credits = value; }
        public int IdSubject { get => idSubject; set => idSubject = value; }

        public Subject()
        {

        }

        public Subject(string Name, int Time, int Credits, int IDsubject){
            this.Name = Name;
            this.Time = Time;
            this.Credits = Credits;
            this.IdSubject = IDsubject;
        }


    }
}