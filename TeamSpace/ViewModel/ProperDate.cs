using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeamSpace.ViewModel
{
    public class ProperDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime time;
            var  isValid = DateTime.TryParseExact(Convert.ToString(value), 
                "d MMM YYYY", 
                CultureInfo.CurrentCulture, 
                DateTimeStyles.None, out time);
            //checking if required time is in future
            return (isValid && time > DateTime.Now);
        }
    }
}