﻿Console.Write("Enter user name ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Hey, this is Masha!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}