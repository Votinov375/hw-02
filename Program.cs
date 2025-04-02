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


Console.Write("Enter the Number:");
string? input = "";
input = Console.ReadLine();
long result = long.Parse(input);

if (result >= -128 && result <= 127 ) {
    Console.WriteLine("sbyte ok");
    }
else {Console.WriteLine("sbyte not ok");}

if (result >= -32768 && result <= 32767 ) {
    Console.WriteLine("short ok");
    }
else {Console.WriteLine("short not ok");}

if (result >= -2147483648 && result <= 2147483647 ) {
    Console.WriteLine("int ok");
    }
else {Console.WriteLine("int not ok");}

if (result >= -9223372036854775808 && result <= 9223372036854775807 ) {
    Console.WriteLine("long ok");
    }
else {Console.WriteLine("long not ok");}

if (result >= 0 && result <= 255 ) {
    Console.WriteLine("byte ok");
    }
else {Console.WriteLine("byte not ok");}

if (result >= 0 && result <= 65535 ) {
    Console.WriteLine("ushort ok");
    }
else {Console.WriteLine("ushort not ok");}

if (result >= 0 && result <= 4294967295 ) {
    Console.WriteLine("uint ok");
    }
else {Console.WriteLine("uint not ok");}

if (result >= 0 && result <= 18446744073709551615 ) {
    Console.WriteLine("ulong ok");
    }
else {Console.WriteLine("ulong not ok");}



/*
int a = 3;
int b = 2;
if (a > b) Console.WriteLine("a > b");
if (a < b) Console.WriteLine("a < b");
byte a = 254;
byte b = 0;
if (a == 255) Console.WriteLine("Max");
if (a < 255) Console.WriteLine("Not Max");
*/