using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.CreationalDesignPatternPrograms.PrototypeDesignPattern
{
    class Employee:ICloneable
    {
        private List<String> empList;

        public Employee()
        {
            empList = new List<string>();
        }

        public Employee(List<String> list)
        {
            this.empList = list;
        }
        public void loadData()
        {
            //read all employees from database and put into the list
            empList.Add("Pankaj");
            empList.Add("Raj");
            empList.Add("David");
            empList.Add("Lisa");
        }

        public List<String> getEmpList()
        {
            return empList;
        }

        public object Clone()
        {
            List<string> temp = new List<string>();
            foreach (string str in getEmpList())
            {
                temp.Add(str);
            }
            return new Employee(temp);
        }
    }
 }

