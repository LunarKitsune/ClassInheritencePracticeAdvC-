using System;
using Person;

namespace Student
{
    public class student : person
    {
        double credits;
        double points;

        public student(string SName, int SAge, int SID, double Credit, double point)
            :base(SName, SAge, SID)
        {
            credits = Credit;
            points = point;
        }

        public override double GetGPA()
        {
            return points / credits;
        }

        public override string ToString()
        {
            string output = string.Empty;
            double GPA = GetGPA();

            output += $"Student Name: {Name}\n";
            output += $"Student ID: {ID}\n";
            output += $"Student Age: {Age}";
            output += $"Credits: {credits}\n";
            output += $"Points: {points}\n";
            output += $"GPA earned: {GPA:N2}\n";

            //this will be what is returned
            return output;
        }
    }
}
