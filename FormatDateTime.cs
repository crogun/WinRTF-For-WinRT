/**
 * Author : BEN OUIREN Farid
 * Date :2013-03-16
 * email : crogun@gmail.com
 * Licence : Creative Commons 
 * The licensor permits others to copy, distribute, display, and perform the work. In return, licenses must give the original author credit.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestORMSQlite.WinRTF
{
    public class FormatDateTime
    {
        private static FormatDateTime instance = null;


        public static FormatDateTime Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FormatDateTime();
                }
                return instance;
            }
        }


        public string format(DateTime date)
        {
            string res = "" + date.Year + "-";

            if (date.Month < 10)
                res += "0" + date.Month;
            else
                res += date.Month;
            res+= "-";
            if (date.Day < 10)
                res += "0" + date.Day;
            else
                res += date.Day;

            res += " ";

            if (date.Hour < 10)
                res += "0" + date.Hour;
            else
                res += date.Hour;
            res += ":"; 
            if (date.Minute < 10)
                res += "0" + date.Minute;
            else
                res += date.Minute;
            res += ":";
            if (date.Second < 10)
                res += "0" + date.Second;
            else
                res += date.Second;
            return res;

        }

        public string formatDay(DateTime date)
        {
            string res = "" + date.Year + "-";

            if (date.Month < 10)
                res += "0" + date.Month;
            else
                res += date.Month;
            res += "-";
            if (date.Day < 10)
                res += "0" + date.Day;
            else
                res += date.Day;
            return res;

        }


        public string formatHour(DateTime date)
        {
            string res = " ";

            if (date.Hour < 10)
                res += "0" + date.Hour;
            else
                res += date.Hour;
            res += ":";
            if (date.Minute < 10)
                res += "0" + date.Minute;
            else
                res += date.Minute;
            res += ":";
            if (date.Second < 10)
                res += "0" + date.Second;
            else
                res += date.Second;
            return res;
        }


    }
}
