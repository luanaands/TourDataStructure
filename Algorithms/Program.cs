using Algorithms;

if (args.Length==0){
    Console.WriteLine("Can't to continue");
    return;
}

int[] numbersDisordered = new int[args.Length-1];
for (int i = 1; i < args.Length; i++)
{
    if (!int.TryParse(args[i], out numbersDisordered[i-1]))
    {
        Console.WriteLine($"All parameters must be integers. Could not convert {args[i]}");
        return;
    }
}

List<ISort>
algorithms =
[
    new SelectionSort(),
    new InsertionSort(),
    new BubbleSort()
];

var sort = algorithms.FirstOrDefault(a => a.IsApplicable(args[0]));
Console.WriteLine("Numbers disordered:");
Console.WriteLine("\t\t\t\t" + string.Join("\t", numbersDisordered));

if (sort != null)
{
    sort.Handle(numbersDisordered);
    Console.WriteLine("\t\t\t\t" + string.Join("\t", numbersDisordered));
}
else
{
    Console.WriteLine("Algorithm not found");
}
