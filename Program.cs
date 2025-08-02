using CSharpRouteSessions.Q1;
using CSharpRouteSessions.Q2;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpRouteSessions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1.Design and implement a Class for the employees in a company:
            //Notes:
            //•	Employee is identified by an ID, Name, security level, salary, hire date and Gender.
            //•	We need to restrict the Gender field to be only M or F[Male or Female] 
            //•	Assign the following security privileges to the employee(guest, Developer, secretary and DBA) in a form of Enum.
            //•	We want to provide the Employee Class to represent Employee data in a string Form(override ToString()),
            //display employee salary in a currency format. [Use String.Format() Function].

            Employee employee = new Employee(1, "John Doe", 50000,new HireDate(2000, 01, 01),Gender.M,SecurityLevel.Developer);

            Console.WriteLine(employee.ToString());
            #endregion

            #region Q2
            HireDate hireDate = new HireDate(2023, 10, 5);

            Console.WriteLine(hireDate);
            #endregion

            #region Q3
            Employee[] EmpArr = new Employee[3];
            EmpArr[0] = new Employee(1, "Alice", 60000, new HireDate(2019, 5, 20),Gender.F, SecurityLevel.DBA);
            EmpArr[1] = new Employee(2, "Bob", 70000, new HireDate(2018, 3, 15),Gender.M, SecurityLevel.Guest);
            EmpArr[2] = new Employee(3, "Charlie", 80000, new HireDate(2021, 3, 17),Gender.F, SecurityLevel.FullAccess);

            #endregion

            #region Q4

            Employee temp = EmpArr[0];

            for (int i = 0; i < EmpArr.Length; i++)
            {
                for(int j = i + 1; j < EmpArr.Length; j++)
                {
                    //if (EmpArr[j]?.GetHireDate()?.Year < EmpArr[i]?.GetHireDate()?.Year)
                    //{
                    //    temp = EmpArr[i];
                    //    EmpArr[i] = EmpArr[j];
                    //    EmpArr[j] = temp;
                    //}
                    //else
                    //{
                    //    if (EmpArr[j]?.GetHireDate()?.Year == EmpArr[i]?.GetHireDate()?.Year)
                    //    {
                    //        if (EmpArr[j]?.GetHireDate()?.Month < EmpArr[i]?.GetHireDate()?.Month)
                    //        {
                    //            temp = EmpArr[i];
                    //            EmpArr[i] = EmpArr[j];
                    //            EmpArr[j] = temp;
                    //        } else                             {
                    //            if (EmpArr[j]?.GetHireDate()?.Month == EmpArr[i]?.GetHireDate()?.Month)
                    //            {
                    //                if (EmpArr[j]?.GetHireDate()?.Day < EmpArr[i]?.GetHireDate()?.Day)
                    //                {
                    //                    temp = EmpArr[i];
                    //                    EmpArr[i] = EmpArr[j];
                    //                    EmpArr[j] = temp;
                    //                }
                    //            }
                    //        }
                    //}
                    // or using the SamllerThan method of HireDate

                    if (EmpArr[j].GetHireDate().SmallerThan(EmpArr[i].GetHireDate()))
                    {
                        temp = EmpArr[i];
                        EmpArr[i] = EmpArr[j];
                        EmpArr[j] = temp;
                    }
                }
            }

            Console.WriteLine("Employees sorted by Hire Date:");
            foreach (var emp in EmpArr)
            {
                Console.WriteLine(emp.ToString());
            }
            #endregion


            #region Q5
            // i made book with the main 3 attributes and inherit these there for ebook and printed book then add the last differant attribute for each drived class[ebook , printed book]
            #endregion
        }
    }
}
