using System;
using System.Linq;
using System.Collections.Generic;

namespace QueryExpressions {
    class MainClass {
        public static void Main(string[] args) {
            List<Person> allPeople = new List<Person>();
            Random rand = new Random(1337);

            for (int height = 60; height <= 84; height++) {
                allPeople.Add(new Person(height, rand.Next(120, 250)));
            }
                
            IEnumerable<Person> overweight = 
                    from person in allPeople
                    where CalcBmi(person.Weight, person.Height) > 25
                    select person;

            IEnumerable<Person> idealweight =
                    from person in allPeople
                    where CalcBmi(person.Weight, person.Height) < 25
                    where CalcBmi(person.Weight, person.Height) > 20
                    select person;

            Console.WriteLine("All Weight");
            foreach (Person person in allPeople) {
                Console.WriteLine($"Weight: {person.Weight}, Height: {person.Height}");
            }  
            Console.WriteLine();
            Console.WriteLine("Overweight");
            foreach (Person person in overweight) {
                Console.WriteLine($"Weight: {person.Weight}, Height: {person.Height}");
            }  
            Console.WriteLine();
            Console.WriteLine("Ideal Weight");
            foreach (Person person in idealweight) {
                Console.WriteLine($"Weight: {person.Weight}, Height: {person.Height}");
            }            
        }

        public static int CalcBmi(int weight, int height) {
            return (int)Math.Round((double)((703 * weight) / (height * height)));
        }
    }
}
