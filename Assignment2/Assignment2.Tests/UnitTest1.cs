using System;
using Xunit;
using StudentLibrary;

namespace Assignment2.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ToString_Given_Oscar_Strange_2023_06_30_and_2020_09_01_returns_toString()
        {
            Student student = new Student(1);
            student.GivenName = "Oscar";
            student.Surname = "Strange";
            student.GraduationDate = new DateTime(2023, 06, 30);
            student.EndDate = new DateTime(2023, 06, 30);
            student.StartDate = new DateTime(2020, 09, 01);

            string expected = $"ID: {student.ID} \nName: {student.GivenName} {student.Surname}, Status: {student.Status}";
            Assert.Equal(expected, student.ToString());

        }

        [Fact]
        public void ToString_ImmutableStudent_Given_Oscar_Strange_2023_06_30_and_2020_09_01_returns_toString()
        {
            ImmutableStudent student = new ImmutableStudent(1, "Oscar", "Strange", new DateTime(2023, 06, 30), new DateTime(2023, 06, 30), new DateTime(2020, 09, 01));

            string expected = "ImmutableStudent { ID = " + student.ID + ", GivenName = " + student.GivenName + ", Surname = " + student.Surname + ", Status = " + student.Status + ", StartDate = " + student.StartDate + ", EndDate = " + student.EndDate + ", GraduationDate = " + student.GraduationDate + " }";
            Assert.Equal(expected, student.ToString());

        }

        [Fact]
        public void equality_comparer_given_two_not_equal_students_returns_false(){
            ImmutableStudent studentOscar = new ImmutableStudent(1, "Oscar", "Strange", new DateTime(2023, 06, 30), new DateTime(2023, 06, 30), new DateTime(2020, 09, 01));
            ImmutableStudent studentLine = new ImmutableStudent(2, "Line", "Dejgaard", new DateTime(2025, 06, 30), new DateTime(2025, 06, 30), new DateTime(2022, 08, 30));

            Assert.False(studentLine == studentOscar);

        }

        [Fact]
        public void equality_comparer_given_two_equal_students_returns_true(){
            ImmutableStudent student1 = new ImmutableStudent(1, "Oscar", "Strange", new DateTime(2023, 06, 30), new DateTime(2023, 06, 30), new DateTime(2020, 09, 01));
            ImmutableStudent student2 = new ImmutableStudent(1, "Oscar", "Strange", new DateTime(2023, 06, 30), new DateTime(2023, 06, 30), new DateTime(2020, 09, 01));

            Assert.False(student1 == student2);

        }


    }
}
