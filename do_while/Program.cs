﻿Random random = new Random();
int current = 0;

do
{
    // This code executes at least one time
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);