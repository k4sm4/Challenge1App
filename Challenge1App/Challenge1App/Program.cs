﻿using System.Diagnostics.Metrics;

int number = 154864;
string numberAsString = number.ToString();
char[] digit = numberAsString.ToArray();

Console.WriteLine("The result for number " + number);
Console.WriteLine("");
int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char letter in digit)
{
    if (letter == '0')
    { 
        counter0++;
    }
    else if(letter == '1')
    {
        counter1++;
    }
    else if(letter == '2')
    {
        counter2++;
    }
    else if(letter == '3')
    {
        counter3++;
    }
    else if(letter == '4')
    {
        counter4++;
    }
    else if(letter == '5')
    {
        counter5++;
    }
    else if(letter == '6')
    {
        counter6++;
    }
    else if(letter == '7')
    {
        counter7++;
    }
    else if(letter == '8')
    {
        counter8++;
    }
    else if(letter == '9')
    {
        counter9++;
    }
}
Console.WriteLine("Digi 0 was used = " + counter0);
Console.WriteLine("Digi 1 was used = " + counter1);
Console.WriteLine("Digi 2 was used = " + counter2);
Console.WriteLine("Digi 3 was used = " + counter3);
Console.WriteLine("Digi 4 was used = " + counter4);
Console.WriteLine("Digi 5 was used = " + counter5);
Console.WriteLine("Digi 6 was used = " + counter6);
Console.WriteLine("Digi 7 was used = " + counter7);
Console.WriteLine("Digi 8 was used = " + counter8);
Console.WriteLine("Digi 9 was used = " + counter9);

Console.ReadLine();