using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    [TypeConverter(typeof(HumanConert))]
    public class Human
    {
        public string Name { get; set; }

        public Human Child { get; set; }

    }
}
