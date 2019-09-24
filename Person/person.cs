using System;

namespace Person
{
    public abstract class person
    {
        protected string Name;
        protected int Age;
        protected int ID;
        
        public person(string name, int age, int id)
        {
            Name = name;
            Age = age;
            ID = id;
        }

        public abstract double GetGPA();

        public abstract override string ToString();

    }
}
