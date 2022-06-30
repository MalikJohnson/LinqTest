// See https://aka.ms/new-console-template for more information

//Linq test compared to sql

List<string> words = new List<string>();

var hashMap =   new Dictionary<int, string>();

int[] testNum = { 50, 1, -1, 66, -80, 1000, 682, -972, 0, 30, 20, 66, 94, 28 };

IEnumerable<int> testQuery =
    from num in testNum
    where num > 20
    select num;

// Execute the query.
foreach (int z in testQuery)
{
    Console.Write(z + " ");
}

Console.WriteLine("Hello, World!");
