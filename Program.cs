using System;

public struct Bits
{
    private int value;

    public Bits(int value)
    {
        this.value = value;
    }

    public static implicit operator Bits(long value)
    {
        return new Bits((int)value);
    }

    public static implicit operator Bits(int value)
    {
        return new Bits(value);
    }

    public static implicit operator Bits(byte value)
    {
        return new Bits(value);
    }

    public override string ToString()
    {
        return Convert.ToString(value, 2);
    }
}

class Program
{
    static void Main()
    {
        long longValue = 123456789;
        Bits bitsFromLong = longValue;
        Console.WriteLine(bitsFromLong);

        int intValue = 255;
        Bits bitsFromInt = intValue;
        Console.WriteLine(bitsFromInt);

        byte byteValue = 7;
        Bits bitsFromByte = byteValue;
        Console.WriteLine(bitsFromByte);
    }
}