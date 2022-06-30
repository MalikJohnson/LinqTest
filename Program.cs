﻿// See https://aka.ms/new-console-template for more information

//Linq test compared to sql

List<string> words = new List<string>();

var hashMap =   new Dictionary<int, string>();

int[] testNum = { 50, 1, -1, 66, -80, 1000, 682, -972, 0, 30, 20, 66, 94, 28 };


words.Add("hello");
words.Add("test");
words.Add("goodbye");
words.Add("tree");
words.Add("map");
words.Add("stack");
words.Add("queue");

IEnumerable<int> testQuery =
    from num in testNum
    where num < 0
    select num;

IEnumerable<String> wordQuery =
    from word in words
    where word.StartsWith('t')
    select word;

// Execute the query.
/*foreach (int z in testQuery)
{
    Console.Write(z + " ");
}*/

foreach (string b in wordQuery)
{
    Console.Write(b + " ");
}


//Console.WriteLine("Hello, World!");
