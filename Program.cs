// See https://aka.ms/new-console-template for more information

//Linq test compared to sql

List<string> words = new List<string>();

var hashMap =   new Dictionary<string, string>();

int[] testNum = { 50, 1, -1, 66, -80, 1000, 682, -972, 0, 30, 20, 66, 94, 28 };


words.Add("hello");
words.Add("test");
words.Add("goodbye");
words.Add("tree");
words.Add("map");
words.Add("stack");
words.Add("queue");

hashMap.Add("hello", "greeating");
hashMap.Add("goodbye", "parting");
hashMap.Add("book", "novel");
hashMap.Add("motherboard", "links the entire computer");
hashMap.Add("hard drive", "stores operating system and files");
hashMap.Add("cpu", "processor");
hashMap.Add("ram", "memory");
hashMap.Add("psu", "power supply unit");
hashMap.Add("gpu", "graphical processing unit");
hashMap.Add("cpu fan", "cools cpu");
hashMap.Add("wifi card", "pci express card for wifi connections");

    var  testQuery =
    from num in testNum
    where num < 0
    select num;

    var wordQuery =
    from word in words
    where word.StartsWith('t')
    select word;

    var mapQuery = from x in hashMap
    where x.Key.Contains("cpu")
    select x;

// Execute the query.
/*foreach (int z in testQuery)
{
    Console.Write(z + " ");
}*/

/*foreach (string b in wordQuery)
{
    Console.Write(b + " ");
}*/

foreach (var result in mapQuery)
{
    Console.WriteLine(result.Key);
}


//Console.WriteLine("Hello, World!");
