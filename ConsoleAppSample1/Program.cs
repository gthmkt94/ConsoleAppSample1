// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

bool isEsc = false;
while (!isEsc)
{
    Console.WriteLine($"キーを入力してください。");
    var input = Console.ReadKey(true);
    Console.WriteLine($"{input.Key} が入力されました。");

    isEsc = input.Key == ConsoleKey.Escape;
}

Console.WriteLine($"アプリを終了します。");
Console.ReadKey();