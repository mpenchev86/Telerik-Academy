namespace People
{
    using System;

    internal class PersonGenerator
    {
        public enum Gender
        {
            male,
            female
        }
        
        public void MakePerson(int age)
        {
            Person newPerson = new Person();
            newPerson.Age = age;
            if (age % 2 == 0)
            {
                newPerson.Name = "John Doe";
                newPerson.Gender = Gender.male;
            }
            else
            {
                newPerson.Name = "Jane Doe";
                newPerson.Gender = Gender.female;
            }
        }

        internal class Person
        {
            public Gender Gender
            {
                get;
                set;
            }

            public string Name
            {
                get;
                set;
            }

            public int Age
            {
                get;
                set;
            }
        }
    }
}