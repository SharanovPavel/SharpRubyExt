using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpRubyExt.Numbers.Times.Signed
{
    public static partial class IntExt
    {
        public static void Times(this Int64 number, Action<Int64> action)
        {
            for (Int64 i = 0; i < number; i++)
            {
                action.Invoke(i);
            }
        }

        public static void Times(this Int64 number, Action action)
        {
            for (Int64 i = 0; i < number; i++)
            {
                action.Invoke();
            }
        }
    }
}
