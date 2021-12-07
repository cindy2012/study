﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingToMethod
{
    public class DoubleToString : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value?.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var val = value as string;
            if (val != null)
            {
                double d;
                if (double.TryParse(val, out d))
                {
                    return d;
                }
            }
            
                return null;

        }
    }
}
