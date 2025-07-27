using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRouteSessions
{
    internal class Employee
    {
        #region Attributes
        private int Id;
        private string Name;
        private decimal Salary;
        #endregion
        #region Constructors
        // Default constructor
        public Employee()
        {
            Id = 0;
            Name = "Unknown";
            Salary = 0.0m;
        }
        public Employee(int id, string name,decimal salary)
        {
            Id = id;
            SetName(name); // using setter method for encapsulation
            this.salary = salary; // using property for encapsulation
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"Employee [Id={Id}, Name={Name}, Salary={Salary}]";
        }
        #endregion

        #region Encapsulation
        #region Getters and Setters
        public void SetName(string name)
        {
            this.Name = name;
        }
        public string GetName()
        {
            return this.Name;
        }
        public int GetId()
        {
            return this.Id;
        }
        //public void SetSalary(decimal salary)
        //{
        //    if (salary < 0)
        //    {
        //        throw new ArgumentException("Salary cannot be negative.");
        //    }
        //    this.Salary = salary;
        //}
        //public decimal GetSalary()
        //{
        //    return this.Salary;
        //}
        #endregion

        #region Properties
        #region full properties
        public decimal salary // name for using at in program
        {
            // use attribute name here
            get { return Salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative.");
                }
                Salary = value;
            }
        }
        #endregion

        #region auto properties
        public int Age { get; set; } // auto property with public access modifier
        // hidden backing private field is created by the compiler

        // read-only auto property
        public decimal DiscountedSalary 
        { 
            get { return Salary * 0.9m; } // 10% discount on salary
            // no setter, so it is read-only
        }
        #endregion

        #region indexer

        #endregion

        #endregion
        #endregion
    }
}
