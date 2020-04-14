using System;

namespace Hashing
{
    public class Student
    {
        private String name;
        private Decimal gpa;
        private UInt32 Id { get; }

        public Student(UInt32 id, String name, Decimal gpa)
        {
            Id = id;
            Name = name;
            Gpa = gpa;
        }

        public String Name
        {
            get => name;
            set => name = value ?? throw new Exception("Name cannot be null!");
        }

        public Decimal Gpa
        {
            get => gpa;
            set
            {
                if (value < 0.0m || value > 4.0m)
                {
                    throw new Exception("GPA must be between 0.0 and 4.0 inclusive");
                }
                
                gpa = value;
            }
        }

        public override Int32 GetHashCode()
        {
            String id = Id.ToString().PadLeft(8, '0');
            
            return Int32.Parse(id);
        }
    }
}
