using System;

namespace SharpRuby.Numbers
{
    public static partial class UIntExt
    {
        public static void Upto(this UInt16 from, UInt64 to, Action action)
        {
            for (UInt16 i = from; i <= to; i++)
            {
                action.Invoke();
            }
        }

        public static void Upto(this UInt16 from, UInt32 to, Action action)
        {
            for (UInt16 i = from; i <= to; i++)
            {
                action.Invoke();
            }
        }

        public static void Upto(this UInt16 from, UInt16 to, Action action)
        {
            for (UInt16 i = from; i <= to; i++)
            {
                action.Invoke();
            }
        }
    }
}
