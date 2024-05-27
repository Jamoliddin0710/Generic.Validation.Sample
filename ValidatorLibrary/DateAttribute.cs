using Library;
using Library.TimeExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorLibrary
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class DateAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null) return true;

            var (FirstDayOfMonth, LastDayOfMonth) = DateTime.Now.FirstAndLastDayOfMonth();
            
            if(!Convert.ToDateTime(value).Between(FirstDayOfMonth, LastDayOfMonth)) return false;

            return true;
        }
    }
}
