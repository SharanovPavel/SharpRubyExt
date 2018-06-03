using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpRubyExt.Numbers
{
    public static partial class IntExt
    {
        public static void Times(this sbyte number, Action action)
        {
            for (sbyte i = 0; i < number; i++)
            {
                action.Invoke();
            }
        }

        public static void Times(this sbyte number, Action<sbyte> action)
        {
            for (sbyte i = 0; i < number; i++)
            {
                action.Invoke(i);
            }
        }
    }
}
