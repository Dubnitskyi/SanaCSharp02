Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;
System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

int n;
bool ok;
do
{
    Console.WriteLine("Введіть число n = ");
    ok = int.TryParse(Console.ReadLine(), out n);
    if (!ok) Console.WriteLine("Число введено неправельно , повторіть спробу!\n");
} while (!ok);

double a = 0;
for (int i = 0; i < n; i++)
{
    a += ((Math.Pow(-1, i)) / (2 * i + 1));
}
Console.WriteLine($"a = {a:F2}");

double b = 0;
for(int i = 0; i < n; i++)
{
    b += (1 + (1 / Math.Pow(i, 2)));
}
Console.WriteLine($"b = {b:F2}");

int c = 1;
for (int i = 0; i < n; i++)
{
    c += c * i ;
}
Console.WriteLine($"c = {c}");

