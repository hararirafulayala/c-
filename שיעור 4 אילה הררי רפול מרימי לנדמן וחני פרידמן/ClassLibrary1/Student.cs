using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student: IComparable<Student>, IEquatable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double age { get; set; }

        public Student()
        {
            
        }
        public Student(int Id, string Name, double age)
        {
            this.Id = Id;   
            this.Name = Name;   
            this.age = age; 

            
        }

        public int CompareTo(Student? other)
        {
            if (other == null) throw new Exception("אא להשוות עם נל");

            if (this.Id.CompareTo(other.Id) == 0) return 0;
            if (this.Id.CompareTo(other.Id) > 1) return -1;
            return 1;

        }


        public bool Equals(Student? other) => this.Name.Equals(other.Name);
     
    }
}
