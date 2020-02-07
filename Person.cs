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
        private string phoneNumber;

        public Person()
            {}

        public Person (string name, bool isMale, int age, string address, string emailAddress, string phoneNumber)
        {
            this.name = name;
            this.isMale = isMale;
            this.age = age;
            this.address = address;
            this.emailAddress = emailAddress;
            this.phoneNumber = phoneNumber;
        }

        public string GetName()
        {
            return this.name;
        }

        public bool GetIsMale()
        {
            return this.isMale;
        }

        public int GetAge()
        {
            return this.age;
        }

        public string GetAddress()
        {
            return this.address;
        }

        public string GetEmailAddress()
        {
            return this.emailAddress;
        }

        public string GetPhoneNumber()
        {
            return this.phoneNumber;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public void SetEmailAddress(string emailAddress)
        {
            this.emailAddress = emailAddress;
        }

        public void SetPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
    }
}



