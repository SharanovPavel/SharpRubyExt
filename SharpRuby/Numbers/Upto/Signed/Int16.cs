using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpRubyExt.Numbers.Times.Signed
{
    public static partial class IntExt
    {
        public static void Upto(this Int16 from, Int64 to, Action action)
        {
            for (Int16 i = from; i <= to; i++)
            {
                action.Invoke();
            }
        }

        public static void Upto(this Int16 from, Int32 to, Action action)
        {
            for (Int16 i = from; i <= to; i++)
            {
                action.Invoke();
            }
        }

        public static void Upto(this Int16 from, Int16 to, Action action)
        {
            for (Int16 i = from; i <= to; i++)
            {
                action.Invoke();
            }
        }
    }
}
