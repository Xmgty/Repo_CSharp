using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    [Serializable]
    class Phone
    {
        public BindingList<Option> Options { get; set; }
        public string Model { get; set; }
        public string OS { get; set; }
        public string CPU { get; set; }
        public decimal Price { get; set; }
        public Bitmap MyImage { get; set; }

        public override string ToString()
        {
            return String.Format("{0}. {1} - {2}. Цена {3}", Model, OS, CPU, Price);
        }
    }
}