using System;

namespace StudentLibrary
{
    public class Student
    {
        public int ID {get; init;}
        public string GivenName{get; set;}
        public string Surname{get; set;}
        public Status Status {get{
            if(GraduationDate<DateTime.Now){
                return Status.Graduated;
            } else if (EndDate<DateTime.Now){
                return Status.Dropout;
            } else if(StartDate>DateTime.Now){
                return Status.New;
            } else {
                return Status.Active;
            }
        }}
        public DateTime StartDate {get; set;}
        public DateTime EndDate {get; set;}
        public DateTime GraduationDate {get; set;}

        public Student(int ID){
            this.ID = ID;
        }

        public override string ToString(){
            return string.Format("ID: {0} \nName: {1} {2}, Status: {3}", ID, GivenName, Surname, Status);
        }



    }

    public enum Status{
        New,
        Active,
        Dropout,
        Graduated
    }
}
