using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRouteSessions.Part02
{
    internal class Duration
    {
        // q1
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        // q2
        public override string ToString()
        {
            return $"Hours:{Hours:D2},Minutes:{Minutes:D2},Seconds:{Seconds:D2}";
        }
        public override bool Equals(object? obj)
        {
            // check type
            //if(obj is Duration)
            //{
            //    Duration other = (Duration)obj;
            //    // compare properties
            //    return this.Hours == other.Hours &&
            //           this.Minutes == other.Minutes &&
            //           this.Seconds == other.Seconds;
            //}

            // more simple version
            if (obj is Duration other)
            {
                return this.Hours == other.Hours &&
                       this.Minutes == other.Minutes &&
                       this.Seconds == other.Seconds;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode(); // or you can implement a custom hash code
        }

        // q3
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int seconds)
        {
            if(Seconds < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(seconds), "Seconds cannot be negative.");
            }
            Hours = seconds / 3600;
            Minutes = (seconds % 3600) / 60;
            Seconds = seconds % 60;
        }

        // q4
        public static Duration operator +(Duration d1, Duration d2)
        {
            int totalSeconds = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds +
                               d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return new Duration(totalSeconds);
        }
        public static Duration operator +(Duration d1, int Seconds)
        {
            int totalSeconds = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds +
                               Seconds;
            return new Duration(totalSeconds);
        }
        public static Duration operator +(int Seconds,Duration d1)
        {
            int totalSeconds = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds +
                               Seconds;
            return new Duration(totalSeconds);
        }
        public static Duration operator ++(Duration d)
        {
            int totalSeconds = d.Hours * 3600 + (d.Minutes + 1) * 60 + d.Seconds;
            return new Duration(totalSeconds);
        }
        public static Duration operator --(Duration d)
        {
            int totalSeconds = d.Hours * 3600 + (d.Minutes - 1) * 60 + d.Seconds;
            return new Duration(totalSeconds);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            int totalSeconds = totalSeconds1 - totalSeconds2;
            return new Duration(totalSeconds > 0? totalSeconds: 0);
        }
        public static bool operator >(Duration d1, Duration d2)
        {
            
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;

            return totalSeconds1 > totalSeconds2;
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;

            return totalSeconds1 < totalSeconds2;
        }
        public static bool operator <=(Duration d1, Duration d2)
        {
            
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;

            return totalSeconds1 <= totalSeconds2;
        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;

            return totalSeconds1 >= totalSeconds2;
        }

        public static bool operator true(Duration d)
        {
            return d.Hours > 0 || d.Minutes > 0 || d.Seconds > 0;
        }
        public static bool operator false(Duration d)
        {
            return d.Hours == 0 && d.Minutes == 0 && d.Seconds == 0;
        }

        public static explicit operator DateTime(Duration d)
        {
            // Convert Duration to DateTime
            int totalSeconds = d.Hours * 3600 + d.Minutes * 60 + d.Seconds;
            int years = totalSeconds / (3600 * 24 * 365);
            totalSeconds -= years * (3600 * 24 * 365);
            int months = totalSeconds / (3600 * 24 * 30);
            totalSeconds -= months * (3600 * 24 * 30);
            int days = totalSeconds / (3600 * 24);
            totalSeconds -= days * (3600 * 24);
            int hours = totalSeconds / 3600;
            totalSeconds -= hours * 3600;
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            return new DateTime(years + 1, months + 1, days + 1, hours, minutes, seconds);
        }
    }
}
