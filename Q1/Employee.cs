using CSharpRouteSessions.Q2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using String = System.String;

namespace CSharpRouteSessions.Q1
{
    [Flags]
    enum SecurityLevel : byte
    {
        Guest = 1, Developer = 2, Secretary = 4, DBA = 8,FullAccess = Guest | Developer | Secretary | DBA
    }

    enum Gender
    {
        M = 1,
        Male = 1,
        F = 2,
        Female = 2
    }
    internal class Employee
    {
        #region Attrabutes
        private Gender gender;

        private SecurityLevel securitylevel;
        #endregion


        #region Properties
        // auto-implemented properties
        public int ID { get; set; }
        public string? Name { get; set; }
        
        public decimal Salary { get; set; }

        //public DateTime HireDate { get; set; }
        private HireDate? HireDate;



        // getter and setter for HireDate
        public HireDate? GetHireDate()
        {
            return HireDate;
        }
        public void SetHireDate(HireDate hireDate)
        {
            if (hireDate != null)
            {
                HireDate = hireDate;
            }
            else
            {
                throw new ArgumentNullException(nameof(hireDate), "Hire date cannot be null.");
            }
        }


        // full properties with validation
        public Gender Gender
        {
            get { return gender; }
            set
            {
                if (Enum.IsDefined(typeof(Gender),value))
                {
                    gender = value;
                } else
                {
                    throw new ArgumentException();
                }
            }
        }

        public SecurityLevel securityLevel { 
            get { return securitylevel; } 
            set 
            {
                if (Enum.IsDefined(typeof(SecurityLevel), value))
                {
                    securitylevel = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            } 
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            //return $"ID = {ID}\nName = {Name}\nSecurity Level = {SecurityLevel}\nSalary = {Salary:C}\nHire Date = {HireDate.ToShortDateString()}";
            return $"ID = {ID}\nName = {Name}\nSecurity Level = {securityLevel}\nSalary = {String.Format("{0:C}",Salary)}\nHire Date = {HireDate}";
        }
        #endregion

        #region Constructors
        public Employee()
        {
        }

        public Employee(int iD, string? name, decimal salary, HireDate? hireDate, Gender gender, SecurityLevel securityLevel)
        {
            ID = iD;
            Name = name;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
            this.securityLevel = securityLevel;
        }
        #endregion
    }
}
