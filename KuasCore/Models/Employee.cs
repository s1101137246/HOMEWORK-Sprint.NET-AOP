using System;

namespace KuasCore.Models
{
    public class Employee
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public Int32 Age { get; set; }

        public override string ToString()
        {
            return "Employee: Id = " + Id + ", Name = " + Name + ".";
        }

    }
}
