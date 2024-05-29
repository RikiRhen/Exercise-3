using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public Person (int age, string fName, string lName, double height, double weight)
        {
            this.age = age;
            this.fName = fName;
            this.lName = lName;
            this.height = height;
            this.weight = weight;
        }

        public int GetAge() { return age; }
        public string GetFName() {  return fName; }
        public string GetLName() {  return lName; }
        public double GetHeight() { return height; }   
        public double GetWeight() { return weight; }   

        public void SetAge(int age) 
        {
            try
            {
                if (age < 1)
                {
                    throw new ArgumentException("Age has to be set to atleast 1.");
                }
                this.age = age;
            } catch (ArgumentException e)
            {
                Console.WriteLine($"Invalid age: {e.Message}");
            }
            
        }
        public void SetFName(string fName)
        {
            try
            {
                if (string.IsNullOrEmpty(fName) || fName.Length < 2 || fName.Length > 10)
                {
                    throw new ArgumentException("First name has to be between 2 and 10 letters.");
                }
                this.fName = fName;
            } catch (ArgumentException e)
            {
                Console.WriteLine($"Invalid first name: {e.Message}");
            }
            
        }
        public void SetLName(string lName) 
        {
            try
            {
                if (string.IsNullOrEmpty(lName) || lName.Length < 5 || lName.Length > 15)
                {
                    throw new ArgumentException("Last name has to be between 5 and 15 letters.");
                }
                this.lName = lName;
            } catch (ArgumentException e)
            {
                Console.WriteLine($"Invalid last name: {e.Message}");
            }
            
        }
        public void SetHeight(double height) { this.height = height;}
        public void SetWeight(double weight) { this.weight = weight;}

        public override string ToString() { return $"Age: {age}, Name: {lName}, {fName}, Height: {height}, Weight: {weight}"; }
        //Allt kan testas med ToString() metoden och asserta att printet är korrekt med ålder, namn etc.
    }
}
