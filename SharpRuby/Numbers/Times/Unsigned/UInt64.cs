using System;

namespace SharpRuby.Numbers
{
    public static partial class UIntExt
    {
        public static void Times(this UInt64 number, Action action)
        {
            for (ulong i = 0; i < number; i++)
            {
                action.Invoke();
            }
        }

        public static void Times(this UInt64 number, Action<UInt64> action)
        {
            for (ulong i = 0; i < number; i++)
            {
                action.Invoke(i);
            }
        }
    }
}
