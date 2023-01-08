Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;
System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

int a, b, c, d, e;
bool ok;

do
{
    Console.WriteLine("Введіть оцінку 1 = ");
    ok = int.TryParse(Console.ReadLine(), out a);
    if (!ok) Console.WriteLine("Число введено неправельно , повторить спробу!\n");
} while (!ok);
do
{
    Console.WriteLine("Введіть оцінку 2 = ");
    ok = int.TryParse(Console.ReadLine(), out b);
    if (!ok) Console.WriteLine("Число введено неправельно , повторить спробу!\n");
} while (!ok);
do
{
    Console.WriteLine("Введіть оцінку 3 = ");
    ok = int.TryParse(Console.ReadLine(), out c);
    if (!ok) Console.WriteLine("Число введено неправельно, повторить спробу!\n");
} while (!ok);
do
{
    Console.WriteLine("Введіть оцінку 4 = ");
    ok = int.TryParse(Console.ReadLine(), out d);
    if (!ok) Console.WriteLine("Число введено неправельно , повторить спробу!\n");
} while (!ok);
do
{
    Console.WriteLine("Введіть оцінку 5 = ");
    ok = int.TryParse(Console.ReadLine(), out e);
    if (!ok) Console.WriteLine("Число введено неправельно, повторить спробу!\n");
} while (!ok);

double ser = (a + b + c + d + e) / 5;

if (ser >= 4)
    Console.WriteLine("В студента доступ !");
else
    Console.WriteLine("В студента немає доступу !");

