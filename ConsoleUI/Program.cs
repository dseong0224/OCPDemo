using OCPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel { FirstName = "Tim", LastName = "Corey" },
                new ManagerModel { FirstName = "Sue", LastName = "Storm" },
                new PersonModel { FirstName = "Nancy", LastName = "Roman" }
            };//made a list and added three people
            
            List<EmployeeModel> employees = new List<EmployeeModel>();
            //made an empty list of employees
            Accounts accountProcessor = new Accounts();
            //made new account that can return an employee given a person model
            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person)); //each person is added as employee
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } IsManager { emp.IsManager } IsExecutive { emp.IsExecutive }"); // do stuff with each employee
            }

            Console.ReadLine();
        }
    }
}
