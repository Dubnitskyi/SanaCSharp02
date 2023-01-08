Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;
System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

double a, b, c;
bool ok;
do
{
    Console.WriteLine("Введіть число a = ");
    ok = double.TryParse(Console.ReadLine(), out a);
    if (!ok) Console.WriteLine("Число введено неправельно , повторить спробу!\n");
} while (!ok);
do
{
    Console.WriteLine("Введіть число b = ");
    ok = double.TryParse(Console.ReadLine(), out b);
    if (!ok) Console.WriteLine("Число введено неправельно , повторить спробу!\n");
} while (!ok);
do
{
    Console.WriteLine("Введіть число c = ");
    ok = double.TryParse(Console.ReadLine(), out c);
    if (!ok) Console.WriteLine("Число введено неправельно, повторить спробу!\n");
} while (!ok);

double x1, x2, disc;
disc = Math.Pow(b, 2) - 4 * a * c;
if (disc < 0)
{
    Console.WriteLine("Квадратное рівняння не має коренів! ");
}
else
{
    if (disc == 0)
    {
        x1 = -b / (2 * a);
        x2 = x1;
    }
    else
    {
        x1 = (-b + Math.Sqrt(disc)) / (2 * a);
        x2 = (-b - Math.Sqrt(disc)) / (2 * a);
    }
    Console.WriteLine($"x1 = {x1:F2}; x2 = {x2:F2}");
}
