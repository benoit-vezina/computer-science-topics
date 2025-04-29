uint a = 0, b = 0, result = 0;

// AND demo
a = 7; b = 4;
result = a & b;
Console.WriteLine(result); // Prints 4

// OR demo
a = 7; b = 4;
result = a | b;
Console.WriteLine(result); // Prints 7

// XOR demo
a = 7; b = 4;
result = a ^ b;
Console.WriteLine(result); // Prints 3

// NOT demo
a = 1;
result = ~a;
Console.WriteLine(result); // Prints uint.Max - 1 (4294967294)
Console.WriteLine(uint.MaxValue);

// LEFT SHIFT demo
a = 1;
result = a << 2;
Console.WriteLine(result); // Prints 4

// RIGHT SHIFT demo
a = 7;
result = a >> 2;
Console.WriteLine(result); // Prints 1