using System;

namespace SharpRubyExt.Numbers
{
    public static partial class IntExt
    {
        public static void Times(this Int16 number, Action<Int16> action)
        {
            for (Int16 i = 0; i < number; i++)
            {
                action.Invoke(i);
            }
        }

        public static void Times(this Int16 number, Action action)
        {
            for (Int16 i = 0; i < number; i++)
            {
                action.Invoke();
            }
        }
    }
}
