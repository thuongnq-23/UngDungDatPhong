using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Phong_Hoc.Module
{
    class ComboboxItem
    {
        public string Ten { get; set; }
        public string Ma { get; set; }

        public override string ToString()
        {
            return Ten;
        }
    }
}
