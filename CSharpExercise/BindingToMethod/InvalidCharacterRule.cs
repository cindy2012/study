using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BindingToMethod
{
    public class InvalidCharacterRule : System.Windows.Controls.ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var myvalue = 0.00d;
            try
            {
                if (((string)value).Length > 0)
                {
                    myvalue = double.Parse((string)value);
                }
            }
            catch (Exception ex)
            {
                return new ValidationResult(false, "Illegal characters or " + ex.Message);
            }
            return new ValidationResult(true,null);
        }
    }
}
