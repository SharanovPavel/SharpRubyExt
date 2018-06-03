using System;

namespace SharpRuby.Numbers
{
    public static partial class UIntExt
    {
        public static void Times(this UInt32 number, Action<UInt32> action)
        {
            for (uint i = 0; i < number; i++)
            {
                action.Invoke(i);
            }
        }

        public static void Times(this UInt32 number, Action action)
        {
            for (uint i = 0; i < number; i++)
            {
                action.Invoke();
            }
        }
    }
}
