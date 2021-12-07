using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindConvertion
{
    class MyData:System.ComponentModel.INotifyPropertyChanged
    {
        public MyData()
        {

        }

        private int theDate;

        public event PropertyChangedEventHandler PropertyChanged;

        public int TheDate
        {
            get { return theDate; }
            set
            {
                theDate = value;
                this.OnPropertyChanged("TheDate");
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
