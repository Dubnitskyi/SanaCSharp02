﻿Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;
System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

int a;
bool ok;

do
{
    Console.WriteLine("Введіть число в діапозоні (0;9) = ");
    ok = int.TryParse(Console.ReadLine(), out a);
    if (!ok || a > 9 || a < 0) Console.WriteLine("Число введено неправельно , повторить спробу!\n");
} while (!ok);

switch (a)
{
    case 0: 
        Console.WriteLine("нуль");break;
    case 1:
        Console.WriteLine("один");break;
    case 2:
        Console.WriteLine("два");break;
    case 3:
        Console.WriteLine("три");break;
    case 4:
        Console.WriteLine("чотири");break;
    case 5:
        Console.WriteLine("п'ять");break;
    case 6:
        Console.WriteLine("шість");break;
    case 7:
        Console.WriteLine("сім");break;
    case 8:
        Console.WriteLine("вісім");break;
    case 9:
        Console.WriteLine("дев'ять");break;
        
        
}
