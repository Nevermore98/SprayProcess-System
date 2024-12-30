using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprayProcessSystem.Model
{
    public class PlcData
    {
        public string Address { get; set; }
        public object Value { get; set; }
        public bool IsSaved { get; set; }

    }

}
