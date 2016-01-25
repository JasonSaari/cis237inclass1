using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee1 = new Employee("Dave", "Barnes", 537.00m);
            Employee employee2 = new Employee("Joe", "Somebody", 125.50m);

            //Create simple int that will be used for value vs reference
            int myNumber = 5;


            //Write the value of the int before the method, call the method, print after call
            Console.WriteLine(myNumber);
            ChangeAnInt(myNumber);
            Console.WriteLine(myNumber);

            //Write the value of the int before the method, call the method, print after call
            Console.WriteLine(employee1.ToString());
            ChangeAnObject(employee1);
            Console.WriteLine(employee1.ToString());
           
            //To illistrate ToString Override.
            //Console.WriteLine(employee.GetFullName());
            //Console.WriteLine(employee.ToString());

            //Showing how to use an array with objects
            Employee[] employees = new Employee[10];

            //Instanciate some employees into the array
            employees[0] = new Employee("James", "Kirk", 453.00m);
            employees[1] = new Employee("Jean-Luc", "Picard", 290.00m);
            employees[2] = new Employee("Benjamin", "Sisko", 578.00m);
            employees[3] = new Employee("Kathryn", "Janeway", 194.00m);
            employees[4] = new Employee("Sterlin", "Archer", 394.00m);


            //A for each loop that will loop through each element fo the Employees array            
            foreach (Employee employee in employees)
            {
                //Check to make sure that the current object is not null.
                //We know that the first 5 have values becasuse we assigned them right above 
                //but the last 5 are null, so we better put in a check.
                if (employee != null)
                {
                    //output the information of the employee
                    Console.WriteLine(employee.ToString());
                }
            }






        }

        //Method take in an interger, which is passed by value 
        //and the changes the value of it.
        static void ChangeAnInt(int myNumber)
        {
            myNumber = 456;
        }    

        //Method thake in an Employee class, which is passed by reference 
        //and the changes a property of it. 
        static void ChangeAnObject(Employee employee)
        {
            employee.FristName = "Jason";

        }
    
    
    
    
    }


}
