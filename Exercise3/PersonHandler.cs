using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class PersonHandler
    {
        //Getters
        public int GetAge(Person pers) { return pers.GetAge(); }
        public string GetFName(Person pers) { return pers.GetFName(); }
        public string GetLName(Person pers) { return pers.GetLName(); }
        public double GetHeight(Person pers) { return pers.GetHeight();}
        public double GetWeight(Person pers) { return pers.GetWeight(); }

        //Setters
        public void SetAge(Person pers, int age) {  pers.SetAge(age);  }
        public void SetFName(Person pers, string fname) {  pers.SetFName(fname); }
        public void SetLName(Person pers, string lname) { pers.SetLName(lname);}
        public void SetHeight(Person pers, double  height) { pers.SetHeight(height);}
        public void SetWeight(Person pers, double weight) { pers.SetWeight(weight);}

        //Skapa ny person
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person result = new(age, fname, lname, height, weight);
            return result;
        }




    }
}
