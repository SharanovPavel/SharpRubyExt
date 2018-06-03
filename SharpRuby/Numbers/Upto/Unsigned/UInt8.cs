using System;

namespace SharpRuby.Numbers
{
    public static partial class UIntExt
    {
        public static void Upto(this byte from, UInt64 to, Action action)
        {
            for (byte i = from; i <= to; i++)
            {
                action.Invoke();
            }
        }
    }
}
