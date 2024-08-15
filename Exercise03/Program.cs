// See https://aka.ms/new-console-template for more information
sbyte sByte = default;
byte Byte = default;
short Short = default;
ushort uShort = default;
int Int = default;
uint UInt = default;
long Long = default;
ulong uLong = default;
float Float = default;
double Double = default;
decimal Decimal = default;

Console.WriteLine("------------------------------------------------------------------------------");
Console.WriteLine(format: "{0,-8} {1,-3} {2, 18} {3, 32}", "Type", "Byte(s) of memory", "Min", "Max");
Console.WriteLine("------------------------------------------------------------------------------");
Console.WriteLine(format: "{0,-8} {1,-3} {2, 32} {3, 32}", nameof(sByte), sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
Console.WriteLine(format: "{0,-8} {1,-3} {2, 32} {3, 32}", nameof(Byte), sizeof(byte), byte.MinValue, sbyte.MaxValue);
Console.WriteLine(format: "{0,-8} {1,-3} {2, 32} {3, 32}", nameof(Short), sizeof(short), short.MinValue, short.MaxValue);
Console.WriteLine(format: "{0,-8} {1,-3} {2, 32} {3, 32}", nameof(uShort), sizeof(ushort), ushort.MinValue, ushort.MaxValue);
Console.WriteLine(format: "{0,-8} {1,-3} {2, 32} {3, 32}", nameof(Int), sizeof(int), int.MinValue, int.MaxValue);
Console.WriteLine(format: "{0,-8} {1,-3} {2, 32} {3, 32}", nameof(UInt), sizeof(uint), uint.MinValue, uint.MaxValue);
Console.WriteLine(format: "{0,-8} {1,-3} {2, 32} {3, 32}", nameof(Long), sizeof(long), long.MinValue, long.MaxValue);
Console.WriteLine(format: "{0,-8} {1,-3} {2, 32} {3, 32}", nameof(Float), sizeof(float), float.MinValue, float.MaxValue);
Console.WriteLine(format: "{0,-8} {1,-3} {2, 32} {3, 32}", nameof(Double), sizeof(double), double.MinValue, double.MaxValue);
Console.WriteLine(format: "{0,-8} {1,-3} {2, 32} {3, 32}", nameof(Decimal), sizeof(decimal), decimal.MinValue, decimal.MaxValue);
Console.WriteLine("------------------------------------------------------------------------------");