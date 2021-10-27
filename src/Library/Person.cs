using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person
    {
        public int age;
        public string name;
        public string Name {get;}
        public int Age {get;}
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}