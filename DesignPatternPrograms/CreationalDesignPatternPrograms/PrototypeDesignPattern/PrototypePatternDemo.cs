using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.CreationalDesignPatternPrograms.PrototypeDesignPattern
{
    class PrototypePatternDemo
    {
        public void ImplementPrototype()
        {
            Employee emps = new Employee();
            emps.loadData();

            //Use the clone method to get the Employee object
            Employee empsNew = (Employee)emps.Clone();
            Employee empsNew1 = (Employee)emps.Clone();
            List<String> list = empsNew.getEmpList();
            list.Add("John");
            List<String> list1 = empsNew1.getEmpList();
            list1.Remove("Pankaj");

            Console.WriteLine("emps List: " + emps.getEmpList());
            Console.WriteLine("empsNew List: " + list);
            Console.WriteLine("empsNew1 List: " + list1);
        }
    }
}
