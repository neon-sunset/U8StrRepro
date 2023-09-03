using System.Runtime.CompilerServices;
using U8Primitives;

internal class Program
{
    private static void Main(string[] args)
    {
        var str = (U8String)"Hello, World!"u8;

        Console.WriteLine(StripSpace(str));
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    private static U8String StripSpace(U8String str)
    {
        return str.Remove(' ');
    }
}