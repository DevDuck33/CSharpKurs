using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Person
    {
        int Id;
        string FirstName;
        string LastName;
        string Address;
        int Age;
        string Gender;


        public Person(int Id, string FirstName, string LastName, string Address, int Age, string Gender)        //konstruktor osoby 
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.Age = Age;
            this.Gender = Gender;
        }
    }
}
