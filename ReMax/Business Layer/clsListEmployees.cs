using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReMax
{
    public class clsListEmployees
    {
        private Dictionary<string, clsEmployees> mylist;
        public clsListEmployees() {
            mylist= new Dictionary<string, clsEmployees>();
        }

        public Dictionary<string, clsEmployees>.ValueCollection Elements
        {
            get => mylist.Values;

        }
        public bool Add(clsEmployees employees)
        {
            if (Exist(employees.employeeID) == false)
            {
                mylist.Add(employees.employeeID, employees);
                return true;
            }
            else { return false; }
        }
        public bool Delete(string id)
        {
            return mylist.Remove(id);
        }
        public clsEmployees Find(string number)
        {
            if (Exist(number) == true)
            {
                return mylist[number];
            }
            else { return null; }

        }
        public bool Exist(string number)
        {
            return mylist.ContainsKey(number);
        }

    }
}