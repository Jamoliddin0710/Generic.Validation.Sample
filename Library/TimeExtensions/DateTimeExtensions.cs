using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.TimeExtensions
{
    public static class DateTimeExtensions
    {
        public static (DateTime FirstDayOfMonth, DateTime LastDayOfMonth) FirstAndLastDayOfMonth(this DateTime dateTime)
        {
            var start = new DateTime(dateTime.Year, dateTime.Month, 1);
            var end = start.AddMonths(1).AddDays(-1).AddSeconds(-1);
            return (start, end);
        }

        public static DateTime LastDayOfMonth(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, DateTime.DaysInMonth(dateTime.Year, dateTime.Month)).AddSeconds(-1);
            // day of the this year and month 
        }

        public static DateTime FirstDayOfMonth(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, 1);
        }
    }
}
