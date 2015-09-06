using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission01
{
    public class TheDate
    {
        private int day, month, year;
        private char separator;
        private string[] monthStrings = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        //Constructors
        public TheDate()
        {
            this.SetDay(1);
            this.SetMonth(1);
            this.SetYear(1);
            this.SetSaparator('/');
        }

        public TheDate(int day, int month, int year)
        {
            //TODO: initialize day, month, year. 
            //Set the separator character as ‘/’.
            this.SetDay(day);
            this.SetMonth(month);
            this.SetYear(year);
            this.SetSaparator('/');
        }
        public TheDate(int day, int month, int year, char separator)
            : this(day, month, year)    //To reuse the code
        {
            //TODO: initialize day, month, year, separator.

            //this.day = d.day;
            //this.month = d.month;
            //this.year = d.year;

            this.SetSaparator(separator);
        }
        public TheDate(TheDate d)
            : this(d.day, d.month, d.year, d.separator)          //To reuse the code
        {
            /*
            TODO: create a copy of object ‘d’. This type of constructor is normally called “copy constructor”.
            Hint: use d.day, d.month
            */

            //this.day = d.day;
            //this.month = d.month;
            //this.year = d.year;
            //this.separator = d.separator;
        }
        //Getter Methods
        public int GetYear()
        {
            //TODO: year is returned.
            return this.year;
        }
        public int GetMonth()
        {
            //TODO: month is returned;
            return this.month;
        }
        public string GetMonthString()
        {
            /*
        TODO: return full name of month in English. For example, if month is 3, then “March” is returned.
        */
            return monthStrings[this.month];
        }
        public int GetDay()
        {
            //TODO: date is returned.
            return this.day;
        }
        //Setter Methods
        public bool SetMonth(int month)
        {
            //TODO: set month. (Range 1 to 12)
            if (month > 0 && month < 13)
            {
                this.month = month;
                return true;
            }
            return false;
        }
        public bool SetYear(int year)
        {
            if (year > 2000)
            {
                this.year = year;
                return true;
            }
            return false;
        }
        public bool SetDay(int day)
        {
            bool isValueValid = false;
            //TODO: set date. (date value depends on month, and leap year status)

            //if (day > 0)
            //{
            //    switch (this.month)
            //    {
            //        //Below all the Months contains 31 Days
            //        case 1:
            //        case 3:
            //        case 5:
            //        case 7:
            //        case 8:
            //        case 10:
            //        case 12:
            //            if (day < 32)
            //                isValueValid = true;
            //            break;
            //        case 2:      //Logic for February
            //            if (year % 4 == 0)      //Leap Year
            //            {
            //                if (day < 30)
            //                    isValueValid = true;
            //            }
            //            else     //Non-Leap Year
            //            {
            //                if (day < 29)
            //                    isValueValid = true;
            //            }
            //            break;
            //        case 4:
            //        case 6:
            //        case 9:
            //        case 11:
            //            if (day < 31)
            //                isValueValid = true;
            //            break;
            //    }
            //}
            //if (isValueValid)
            //    this.day = day;

            /************************Same Thing by using Enum***********************/


            if (day > 0)
            {
                switch ((Month)this.month)
                {
                    case Month.January:
                    case Month.March:
                    case Month.May:
                    case Month.July:
                    case Month.August:
                    case Month.October:
                    case Month.December:
                        if (day < 32)
                            isValueValid = true;
                        break;
                    case Month.February:
                        if (year % 4 == 0)      //Leap Year
                        {
                            if (day < 30)
                                isValueValid = true;
                        }
                        else                   //Non-Leap Year
                        {
                            if (day < 29)
                                isValueValid = true;
                        }
                        break;
                    case Month.April:
                    case Month.June:
                    case Month.September:
                    case Month.November:
                        if (day < 31)
                            isValueValid = true;
                        break;
                }
            }
            if (isValueValid)
                this.day = day;


            return isValueValid;
        }
        public void SetSaparator(char separator)
        {
            //TODO: set separator value.
            this.separator = separator;
        }
        //String Representation
        public String ToString()
        {
            /*
        TODO: Represent date in the form “11/03/2009”. Where ‘/’ is separator. Keep the current separator character in the view.
        */
            return "" + this.day + this.separator + this.month + this.separator + this.year;
        }
        public int Compare(TheDate d)
        {
            int result = 0;
            /*TODO:
            Return 0 if dates are equal
            Return -1 if Object d is less.
            Return 1 if Object d is greater. 
            */
            if (d.year > this.year)
                result = 1;
            else if (d.year < this.year)
                result = -1;
            else
            {
                if (d.month > this.month)
                    result = 1;
                else if (d.month < this.month)
                    result = -1;
                else
                {
                    if (d.day > this.day)
                        result = 1;
                    else if (d.day < this.day)
                        result = -1;
                    else
                        result = 0;
                }
            }

            return result;
        }
        //public long Difference(TheDate d)
        //{
        //    //TODO: Calculate difference of current object with object d in days.
        //}
    }

    public enum Month
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
}