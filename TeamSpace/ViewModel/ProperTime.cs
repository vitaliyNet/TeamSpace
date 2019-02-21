using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace TeamSpace.ViewModel
{
    public class ProperTime : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
             DateTime time;
            var isValid = DateTime.TryParseExact(Convert.ToString(value), "HH:mm",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None, out time);
            return (isValid);
        }
    }
}