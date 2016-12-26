using System;
using System.Collections.Generic;

namespace QueryExpressions {
    public class Person {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public List<Person> Children { get; set; }

        public Person(string firstName, int age, int height, int weight) {
            this.FirstName = firstName;
            this.Age = age;
            this.Height = height;
            this.Weight = weight;
        }

        public Person(int height, int weight) {
            this.Height = height;
            this.Weight = weight;
        }
    }
}

