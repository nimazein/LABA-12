using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_12_v2
{
    class IndexNotFoundException : ApplicationException
    {
        public IndexNotFoundException()
            : base()
        {

        }

        public IndexNotFoundException(string str)
            : base(str)
        {

        }
        public override string ToString()
        {
            return Message;
        }
    }
}
