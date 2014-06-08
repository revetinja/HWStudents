using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWStudents
{
    class Student : IComparable<Object>
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        // Constructor
        public Student(string _email, string _name, string _lastName)
        {
            email = _email;
            name = _name;
            lastName = _lastName;
        }

        // This is comparing
        public int CompareTo(Object obj)
        {
            if (obj == null) return 1;

            if (this.email == ((Student)obj).email)
                return this.email.CompareTo(((Student)obj).email);
            return ((Student)obj).email.CompareTo(this.email)*(-1); // ascending order
        }

        //override of function ToString
        public override string ToString()
        {
            return "Email: " + email + ", name: " + name + ", last name: " + lastName;
        }
    }
}
