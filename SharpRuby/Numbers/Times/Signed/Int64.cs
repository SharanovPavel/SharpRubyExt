using System;

namespace SharpRubyExt.Numbers
{
    public static partial class IntExt
    {
        public static void Times(this Int64 number, Action<Int64> action)
        {
            for (Int64 i = 0L; i < number; i++)
            {
                action.Invoke(i);
            }
        }

        public static void Times(this Int64 number, Action action)
        {
            for (Int64 i = 0L; i < number; i++)
            {
                action.Invoke();
            }
        }
    }
}
