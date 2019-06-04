using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_12_v2
{
    class OutOfRangeException : ApplicationException
    {
        public OutOfRangeException()
            :base()
        {

        }

        public OutOfRangeException(string str)
            : base(str)
        {

        }
        public override string ToString()
        {
            return Message;
        }
    }
}
