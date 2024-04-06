int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int nr0 = 0;
int nr1 = 0;
int nr2 = 0;
int nr3 = 0;
int nr4 = 0;
int nr5 = 0;
int nr6 = 0;
int nr7 = 0;
int nr8 = 0;
int nr9 = 0;

foreach (char sign in letters)
{
    if (sign == '0')
    {
        nr0++;
    }
    else if (sign == '1')
    {
        nr1++;
    }
    else if (sign == '2')
    {
        nr2++;
    }
    else if (sign == '3')
    {
        nr3++;
    }
    else if (sign == '4')
    {
        nr4++;
    }
    else if (sign == '5')
    {
        nr5++;
    }
    else if (sign == '6')
    {
        nr6++;
    }
    else if (sign == '7')
    {
        nr7++;
    }
    else if (sign == '8')
    {
        nr8++;
    }
    else if (sign == '9')
    {
        nr9++;
    }
}

Console.WriteLine("Wynik dla liczby: 4566");
Console.WriteLine($"0 => {nr0}");
Console.WriteLine($"1 => {nr1}");
Console.WriteLine($"2 => {nr2}");
Console.WriteLine($"3 => {nr3}");
Console.WriteLine($"4 => {nr4}");
Console.WriteLine($"5 => {nr5}");
Console.WriteLine($"6 => {nr6}");
Console.WriteLine($"7 => {nr7}");
Console.WriteLine($"8 => {nr8}");
Console.WriteLine($"9 => {nr9}");