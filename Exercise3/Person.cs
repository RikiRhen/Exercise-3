using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly:InternalsVisibleTo("PersonTester")]

namespace Exercise_3
{
    internal class Person
    {
        private int _age;
        private string _fName;
        private string _lName;
        private double _height;
        private double _weight;

        public Person (int age, string fName, string lName, double height, double weight)
        {
            this._age = age;
            this._fName = fName;
            this._lName = lName;
            this._height = height;
            this._weight = weight;
        }

        public int GetAge() { return _age; }
        public string GetFName() {  return _fName; }
        public string GetLName() {  return _lName; }
        public double GetHeight() { return _height; }   
        public double GetWeight() { return _weight; }   

        public void SetAge(int age) 
        {
            try
            {
                if (age < 1)
                {
                    throw new ArgumentException("Age has to be set to atleast 1.");
                }
                this._age = age;
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
                this._fName = fName;
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
                this._lName = lName;
            } catch (ArgumentException e)
            {
                Console.WriteLine($"Invalid last name: {e.Message}");
            }
            
        }
        public void SetHeight(double height) { this._height = height;}
        public void SetWeight(double weight) { this._weight = weight;}

        public override string ToString() { return $"Age: {_age}, Name: {_lName}, {_fName}, Height: {_height}, Weight: {_weight}"; }
        //Allt kan testas med ToString() metoden och asserta att printet är korrekt med ålder, namn etc.
    }
}
