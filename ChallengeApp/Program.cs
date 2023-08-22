using System.Reflection.Metadata.Ecma335;

int number = 4594;
string numberInString = number.ToString();
char[] charArray = numberInString.ToCharArray();

int licznik0 = 0;
int licznik1 = 0;
int licznik2 = 0;
int licznik3 = 0;
int licznik4 = 0;
int licznik5 = 0;
int licznik6 = 0;
int licznik7 = 0;
int licznik8 = 0;
int licznik9 = 0;

foreach (char c in charArray)
{
    if (c == '0')
    {
        licznik0++;
    }
    else if (c == '1')
    {
        licznik1++;
    }
    else if (c == '2')
    {
        licznik2++;
    }
    else if (c == '3')
    {
        licznik3++;
    }
    else if (c == '4')
    {
        licznik4++;
    }
    else if (c == '5')
    {
        licznik5++;
    }
    else if (c == '6')
    {
        licznik6++;
    }
    else if (c == '7')
    {
        licznik7++;
    }
    else if (c == '8')
    {
        licznik8++;
    }
    else if (c == '9')
    {
        licznik9++;
    }
}
Console.WriteLine("0 => " + licznik0 + "\n1 => " + licznik1 + "\n2 => " + licznik2 + "\n3 => " + licznik3 + "\n4 => " + licznik4 + "\n5 => " + licznik5 +
                "\n6 => " + licznik6 + "\n7 => " + licznik7 + "\n8 => " + licznik8 + "\n9 => " + licznik9);