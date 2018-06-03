using System;

namespace SharpRuby.Numbers
{
    public static partial class UIntExt
    {
        public static void Times(this UInt16 number, Action<UInt16> action)
        {
            for (UInt16 i = 0; i < number; i++)
            {
                action.Invoke(i);
            }
        }

        public static void Times(this UInt16 number, Action action)
        {
            for (UInt16 i = 0; i < number; i++)
            {
                action.Invoke();
            }
        }
    }
}
