using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRouteSessions.Q2
{
    internal class HireDate
    {
        private short year;
        private byte month;
        private byte day;


        public short Year
        {
            get { return year; }
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Year must be between 1900 and the current year.");
                }
                year = value;
            }
        }
        public byte Month
        {
            get { return month; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Month must be between 1 and 12.");
                }
                month = value;
            }
        }
        public byte Day
        {
            get { return day; }
            set
            {
                if (value < 1 || value > DateTime.DaysInMonth(year, month))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Day must be valid for the specified month and year.");
                }
                day = value;
            }
        }

        public HireDate(short year, byte month, byte day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public bool SmallerThan(HireDate hiredate2)
        {
            if (Year < hiredate2.Year)
            {
                return true;
            }
            else if (Year == hiredate2.Year)
            {
                if (Month < hiredate2.Month)
                {
                    return true;
                }
                else if (Month == hiredate2.Month)
                {
                    return Day < hiredate2.Day;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return $"{Year}-{Month:D2}-{Day:D2}";
        }
    }
}
