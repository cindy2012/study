using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingToMethod
{
    public class TemperatureScale : System.ComponentModel.INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private TempType tempType;

        public TempType Type
        {
            get { return tempType; }
            set {
                tempType = value;
                OnPropertyChanged("Type");
            }
        }

        private void OnPropertyChanged(string _proppertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(_proppertyName));
        }

        public string ConvertTemp(double degree, TempType temptype)
        {
            this.tempType = temptype;
            switch (temptype)
            {
                case TempType.Celsius:
                    return (degree * 9 / 5 + 32).ToString(CultureInfo.InvariantCulture) + " " + "Fahrenheit";
                case TempType.Fahrenheit:
                    return ((degree - 32) / 9 * 5).ToString(CultureInfo.InvariantCulture) + " " + "Celsius";
            }
            return "Unknown Type";
        }
    }
    public enum TempType
    {
        Celsius,
        Fahrenheit
    }
}
