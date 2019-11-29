using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersAndSetters
{
    class Program
    {
        class Person
        {
            string name;
            string gender;
            int age;
            string idCode;

            public Person(string _name, string _gender, int _age, string _idCode)
            {
                Name = _name;
                gender = _gender;
                Age = _age;
                IdCode = _idCode;
            }

            public string Name //eraldi meetod
            {
                get { return name; }
                set 
                {
                    name = value;
                }

            }
            public string Gender
            {
                get { return gender; }
                set
                {
                    if (value == "male" || value == "female")
                    {
                        gender = value;
                    }
                    else
                    {
                        gender = "unicorn";
                    }
                }
            }

            public string IdCode
            {
                get { return idCode; }
                set
                {
                    if(value.Length == 11)
                    {
                        idCode = value;
                    }
                    else
                    {
                        idCode = "undefined";
                    }
                }
            }
            

            public int Age
            {
                get { return age; }
                set
                {
                    if(value >= 0)
                    {
                        age = value;
                    }
                    else
                    {
                        age = 0;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Person newPerson = new Person("John", "male", 44, "36545498752");
            Console.WriteLine($"A new person {newPerson.Name}");
            newPerson.Name = "Joan";
            Console.WriteLine($"A new person {newPerson.Name}");
            newPerson.Gender = "Fairy";
            Console.WriteLine($"Gender: {newPerson.Gender}");
            Console.WriteLine($"ID Code: { newPerson.IdCode}");
            Console.WriteLine($"Age: {newPerson.Age}");
            Console.ReadLine();

        }

    }
}
