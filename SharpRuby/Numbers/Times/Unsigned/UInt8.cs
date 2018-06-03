using System;

namespace SharpRuby.Numbers
{
    public static partial class UIntExt
    {
        public static void Times(this byte number, Action action)
        {
            for (byte i = 0; i < number; i++)
            {
                action.Invoke();
            }
        }

        public static void Times(this byte number, Action<byte> action)
        {
            for (byte i = 0; i < number; i++)
            {
                action.Invoke(i);
            }
        }
    }
}
