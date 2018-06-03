using System;

namespace SharpRubyExt.Numbers
{
    public static partial class IntExt
    {
        public static void Times(this Int32 number, Action<Int32> action)
        {
            for (Int32 i = 0; i < number; i++)
            {
                action.Invoke(i);
            }
        }

        public static void Times(this Int32 number, Action action)
        {
            for (Int32 i = 0; i < number; i++)
            {
                action.Invoke();
            }
        }
    }
}
