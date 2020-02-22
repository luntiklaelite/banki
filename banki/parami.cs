using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banki
{
    
    public class parami
    {
        public string paramname;
        public object paramvalue;
        public parami(string paramname, object paramvalue)
        {
            this.paramname = paramname;
            this.paramvalue = paramvalue;
        }
    }
}
