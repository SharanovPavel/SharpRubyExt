using System;

namespace SharpRuby.Numbers
{
    public static partial class UIntExt
    {
        public static void Upto(this UInt32 from, UInt64 to, Action action)
        {
            for (UInt64 i = from; i <= to; i++)
            {
                action.Invoke();
            }
        }

        public static void Upto(this UInt32 from, UInt32 to, Action action)
        {
            for (UInt32 i = from; i <= to; i++)
            {
                action.Invoke();
            }
        }
    }
}
