// 1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

int i = 0;
while (i < 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}

{
    Console.WriteLine("-------------------------");
}

//2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

int a = 1;
while (a <= 20)
{
    Console.WriteLine(a);
    a++;
}

{
    Console.WriteLine("-------------------------");
}

//3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

int b = 2;
while (b <= 20)
{
    Console.WriteLine(b);
    b += 2;
}

{
    Console.WriteLine("-------------------------");
}

//4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

int c = 50;
int toplam = 0;

while (c <= 150)
{
    toplam += c;
    c++;
}
{ 
    Console.WriteLine("50 ile 150 arasındaki sayıların toplamı= " + toplam);
}

{
    Console.WriteLine("-------------------------");
}

//5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

// 1 ile 120 arasındaki tek sayıların toplamı=


int d = 1;
int toplam2 = 0;

while (d <= 120)
    {
    toplam2 += d;
    d += 2;
    }
{ 
    Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı= "  + toplam2);
}

{
    Console.WriteLine("-------------------------");
}

// 1 ile 120 arasındaki çift sayıların toplamı=

int e = 2;
int toplam3 = 0;

while (e <= 120)
    {
    toplam3 += e;
    e += 2;
    }
{
    Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı= " + toplam3);
}













