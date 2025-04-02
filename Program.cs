//bool a = true;
//Console.WriteLine("Type: " + typeof(bool) + ", Example: " + a + ", Size: " + sizeof(bool));

//sbyte b = -128;
//Console.WriteLine("Type: " + typeof(sbyte) + ", Example: " + b + ", Size: " + sizeof(sbyte));

//byte c = 255;
//Console.WriteLine("Type: " + typeof(byte) + ", Example: " + c + ", Size: " + sizeof(byte));

//short d = -10000;
//Console.WriteLine("Type: " + typeof(short) + ", Example: " + d + ", Size: " + sizeof(short));

//int e = 1000000000;
//Console.WriteLine("Type: " + typeof(int) + ", Example: " + e + ", Size: " + sizeof(int));

//uint f = 0;
//Console.WriteLine("Type: " + typeof(uint) + ", Example: " + f + ", Size: " + sizeof(uint));

//long g = 1000000000000000000;
//Console.WriteLine("Type: " + typeof(long) + ", Example: " + g + ", Size: " + sizeof(long));

//ushort h = 10000;
//Console.WriteLine("Type: " + typeof(ushort) + ", Example: " + h + ", Size: " + sizeof(ushort));

//ulong i = 20;
//Console.WriteLine("Type: " + typeof(ulong) + ", Example: " + i + ", Size: " + sizeof(ulong));

//float j = 123.45f;
//Console.WriteLine("Type: " + typeof(float) + ", Example: " + j + ", Size: " + sizeof(float));

//double k = 123.45;
//Console.WriteLine("Type: " + typeof(double) + ", Example: " + k + ", Size: " + sizeof(double));

//char l = 'a';
//Console.WriteLine("Type: " + typeof(char) + ", Example: " + l + ", Size: " + sizeof(char));

//decimal m = 246.80m;
//Console.WriteLine("Type: " + typeof(decimal) + ", Example: " + m + ", Size: " + sizeof(decimal));

//string n = "Belhard";
//Console.WriteLine("Type: " + typeof(string) + ", Example: " + n + ", Size: " + "limited by computer resources");


Console.Write("Enter the Number: ");
string input = "";
input = Console.ReadLine();
long result = long.Parse(input);

if (result >= sbyte.MinValue && result <= sbyte.MaxValue) { 
    sbyte res = (sbyte)result;
    Console.WriteLine($"sbyte {res}");
} else {
    string message = $"Для приведения числа {result} к типу sbyte число не может быть больше {sbyte.MaxValue} и меньше {sbyte.MinValue}";
    Console.WriteLine(message);
}

if (result >= short.MinValue && result <= short.MaxValue) {
    short res = (short)result;
    Console.WriteLine($"short {res}");
} else {
    string message = $"Для приведения числа {result} к типу short число не может быть больше {short.MaxValue} и меньше {short.MinValue}";
    Console.WriteLine(message);
}

if (result >= int.MinValue && result <= int.MaxValue) {
    int res = (int)result;
    Console.WriteLine($"int {res}");
} else {
    string message = $"Для приведения числа {result} к типу int число не может быть больше {int.MaxValue} и меньше {int.MinValue}";
    Console.WriteLine(message);
}

if (result >= long.MinValue && result <= long.MaxValue) {
    long res = (long)result;
    Console.WriteLine($"long {res}");
} else {
    string message = $"Для приведения числа {result} к типу long число не может быть больше {long.MaxValue} и меньше {long.MinValue}";
    Console.WriteLine(message);
}

if (result >= byte.MinValue && result <= byte.MaxValue) {
    byte res = (byte)result;
    Console.WriteLine($"byte {res}");
} else {
    string message = $"Для приведения числа {result} к типу byte число не может быть больше {byte.MaxValue} и меньше {byte.MinValue}";
    Console.WriteLine(message);
}

if (result >= ushort.MinValue && result <= ushort.MaxValue) {
    ushort res = (ushort)result;
    Console.WriteLine($"ushort {res}");
} else {
    string message = $"Для приведения числа {result} к типу ushort число не может быть больше {ushort.MaxValue} и меньше {ushort.MinValue}";
    Console.WriteLine(message);
}

if (result >= uint.MinValue && result <= uint.MaxValue) {
    uint res = (uint)result;
    Console.WriteLine($"uint {res}");
} else {
    string message = $"Для приведения числа {result} к типу uint число не может быть больше {uint.MaxValue} и меньше {uint.MinValue}";
    Console.WriteLine(message);
}

// if (result >= ulong.MinValue && result <= ulong.MaxValue) {
//     ulong res = (ulong)result;
//     Console.WriteLine($"ulong {res}");
// } else {
//     string message = $"Для приведения числа {result} к типу ulong число не может быть больше {ulong.MaxValue} и меньше {ulong.MinValue}";
//     Console.WriteLine(message);
// }

