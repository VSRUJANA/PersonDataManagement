using System;
using System.Collections.Generic;
using System.Linq;

namespace Person_Data_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person Data Management System");
            List<Person> listPersonInCity = new List<Person>();
            AddRecords(listPersonInCity);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Retrieving top 2 records from the list with age is less than 60");
            Retrieving_TopTwoRecord_ForAge_LessThanSixty(listPersonInCity);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Checking whether there are teenagers in the list");
            CheckingForTeenagerPerson(listPersonInCity);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Get Average age in the list");
            GetAverageAge(listPersonInCity);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Check whether specific name is present in the list");
            Console.Write("Enter name to be checked : ");
            string name1 = Console.ReadLine();
            CheckForSpecificName(name1, listPersonInCity);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Skip Record from the list if age is less than 60");
            SkipIfLessThanSixty(listPersonInCity);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Remove specific name from in the list");
            Console.Write("Enter name to be removed : ");
            string name2 = Console.ReadLine();
            RemoveSpecificName(name2, listPersonInCity);
        }
        private static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("203456876", "John", "12 Main Street, Newyork,NY", 15));
            listPersonInCity.Add(new Person("203456877", "SAM", "13 Main Ct, Newyork,NY", 25));
            listPersonInCity.Add(new Person("203456878", "Elan", "14 Main Street, Newyork,NY", 35));
            listPersonInCity.Add(new Person("203456879", "Smith", "12 Main Street, Newyork,NY", 45));
            listPersonInCity.Add(new Person("203456880", "SAM", "345 Main Ave, Dayton,OH", 55));
            listPersonInCity.Add(new Person("203456881", "Sue", "32 Cranbrook Rd, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456882", "Winston", "1208 Alex st, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456883", "Mac", "126 Province Ave, Baltimore,NY", 85));
            listPersonInCity.Add(new Person("203456884", "SAM", "126 Province Ave, Baltimore,NY", 95));
            foreach (Person p in listPersonInCity)
            {
                Console.WriteLine("Name :" + p.Name + "\tAge :" + p.Age);
            }
        }
        private static void Retrieving_TopTwoRecord_ForAge_LessThanSixty(List<Person> listPersonsInCity)
        {
            foreach (Person person in listPersonsInCity.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name :" + person.Name + "\tAge :" + person.Age);
            }
        }
        private static void CheckingForTeenagerPerson(List<Person> listPersonsInCity)
        {
            if (listPersonsInCity.Any(e => e.Age >= 13 && e.Age < 19))
            {
                Console.WriteLine("Yes, there are some teenagers in the list");
            }
            else
            {
                Console.WriteLine("There are no teenagers in the list");
            }
        }
        private static void GetAverageAge(List<Person> listPersonInCity)
        {
            double avgAge = listPersonInCity.Average(e => e.Age);
            Console.WriteLine("Average Age : " + Math.Round(avgAge,4));
        }
        private static void CheckForSpecificName(string name, List<Person> listPersonInCity)
        {
            if (listPersonInCity.Any(e => e.Name == name))
            {
                Console.WriteLine(name + " is present in the list");
            }
            else
            {
                Console.WriteLine(name + " is not present in the list");
            }
        }
        private static void SkipIfLessThanSixty(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e => e.Age > 60))
            {
                Console.WriteLine("Name: " + person.Name + "\tAge: " + person.Age);
            }
        }
        public static void RemoveSpecificName(string name, List<Person> personList)
        {
            personList.RemoveAll(e => e.Name.Equals(name));
            Console.WriteLine("Record removed successfully");
            foreach (Person p in personList)
            {
                Console.WriteLine("Name :" + p.Name + "\tAge :" + p.Age);
            }
        }
    }
}
