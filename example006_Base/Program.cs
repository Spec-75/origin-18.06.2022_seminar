﻿int a = 1;
int b = 2;
int d = 6;
int c = 8;
int e = 31;

int max = a;
if (b>max) max = b;
if (c>max) max = c;
if (d>max) max = d;
if (e>max) max = e;
Console.Write("max = ");
Console.WriteLine(max);