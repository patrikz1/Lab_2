﻿// See https://aka.ms/new-console-template for more information
using Lab_2;

Shapes shapes = new Shapes();

string pointCord = Console.ReadLine();
string csvData = Console.ReadLine();


shapes.CsvSeparation(pointCord, csvData);

// kolla om csv data är uppdelat här, isf kan vi skicka den + pointcord tsms till en point metod
// annars skicka med pointcord till csvSep å sen efter uppdelningen i kvar, skicka båda till en point metod.



