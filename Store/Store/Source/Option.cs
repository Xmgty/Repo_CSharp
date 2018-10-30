using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    [Serializable]
    class Option
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return String.Format("{0}", Name);
        }

    }
}