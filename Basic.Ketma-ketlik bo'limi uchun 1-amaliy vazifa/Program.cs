Console.WriteLine("1. Doira yuzi va aylana uzunligini hisoblash");

Console.Write("hisoblamoqchi bo'lgan doira radiusini kiriting. R = ");

double radius = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"doiraning yuzi = {Math.PI * Math.Pow(radius , 2)}");

Console.WriteLine($"aylananing uzunligi = {2 * Math.PI * radius}");


Console.WriteLine("////////////////////////////////////////////////");

Console.WriteLine("2. Valyuta konvertri");

Console.Write("hisoblamoqchi bo'lgan vayuta narxi: ");

double narx = Convert.ToDouble(Console.ReadLine());

Console.Write("hisoblamoqchi bo'lgan vayuta qiymati: ");

double valyuta = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"o'girilgan valyuta qiymati: {narx * valyuta}");


Console.WriteLine("////////////////////////////////////////////////");

Console.WriteLine("3. Yoshni hisoblash");

Console.Write("tug'ilgan yilingizni kiriting: ");

int date =  Convert.ToInt32(Console.ReadLine());

int delta = DateTime.Now.Year - date;

Console.WriteLine($"siz tu'gilganingizga {delta * 365 } kundan oshibdi!!!");