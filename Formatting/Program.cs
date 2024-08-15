using static System.Console;

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

WriteLine(
    format: "{0,3} apples costs {1,4:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

string formatted = string.Format(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);
WriteLine(formatted, numberOfApples, pricePerApple * numberOfApples);
WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples,20:N0}");

string applesText = "Apples";
int applesCount = 1234;

string banabasText = "Bananas";
int banabasCount = 56789;

WriteLine(
    format: "{0,-10} {1,6}",
    arg0: "Name",
    arg1: "Count");

WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: applesText,
    arg1: applesCount);

WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: banabasText,
    arg1: banabasCount);

Write("Type yor first name and press ENTER: ");
string? firstName = ReadLine();

Write("Type yor age and press ENTER: ");
string? age = ReadLine();

WriteLine(
    $"Hello {firstName}, you look good for {age}.");

Write("Press any key combination: ");
ConsoleKeyInfo key = Console.ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
arg0: key.Key,
arg1: key.KeyChar,
arg2: key.Modifiers);