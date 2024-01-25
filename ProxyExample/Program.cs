// See https://aka.ms/new-console-template for more information
using ProxyExample;
SellProdProxy sellproxy = new SellProdProxy();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine(sellproxy.SellProduct("123", "banana"));
Console.WriteLine(sellproxy.SellProduct("123", "orange"));
Console.WriteLine(sellproxy.SellProduct("123", "apple"));
