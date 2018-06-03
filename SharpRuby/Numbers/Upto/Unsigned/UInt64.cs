using System;

namespace SharpRuby.Numbers
{
    public static partial class UIntExt
    {
        public static void Upto(this UInt64 from, UInt64 to, Action action)
        {
            for (UInt64 i = from; i <= to; i++)
            {
                action.Invoke();
            }
        }
    }
}
