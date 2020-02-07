using System;

namespace PersonGenerator
{
    public class Person
    {
        private readonly string name;
        private readonly bool isMale;
        private readonly int age;
        private string address;
        private string emailAddress;
        private string cellPhone;

        public Person()
            {}

        public Person (string name, bool isMale, int age, string address, string emailAddress, string cellPhone)
        {
            this.name = name;
            this.isMale = isMale;
            this.age = age;
            this.address = address;
            this.emailAddress = emailAddress;
            this.cellPhone = cellPhone;
        }

        public string getName()
        {
            
        }
    }
}


// name
// gender
// age
// address
// emailAddress
// cellPhone
