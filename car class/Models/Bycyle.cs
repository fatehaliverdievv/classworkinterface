using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_class.Models
{
    internal class Bycyle:Vehicle
    {
        private string _pedalKind;
        public string PedalKind 
        {
            get { return _pedalKind; }
            set {_pedalKind = value;}
        }
    }
}
