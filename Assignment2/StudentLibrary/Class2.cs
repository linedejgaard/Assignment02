using System;

namespace StudentLibrary
{
    public record ImmutableStudent
    {
        public int ID {get; init;}
        public string GivenName{get; init;}
        public string Surname{get; init;}
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
        public DateTime StartDate {get; init;}
        public DateTime EndDate {get; init;}
        public DateTime GraduationDate {get; init;}

        public ImmutableStudent(int ID, string GivenName, string Surname, DateTime StartDate, DateTime EndDate, DateTime GraduationDate){
            this.ID = ID;
            this.GivenName = GivenName;
            this.Surname = Surname;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.GraduationDate = GraduationDate;

        }

    }
}