using Algoritmos;

if (args.Length==0){
    Console.WriteLine("Can't to continue");
    return;
}

int[] numbersDisordered = new int[args.Length];
for(int i = 0; i < args.Length; i++){
    if(!int.TryParse(args[i], out numbersDisordered[i])){
         Console.WriteLine($"All parameters must be integers. Could not convert {args[i]}");
         return;
    }
}

//Retire o comentário o qual algoritmo deseja executar 
Console.WriteLine("\t\t" + string.Join("\t", numbersDisordered));
//Console.WriteLine("Insertion sort " + string.Join("\t", InsertionSort.Handle(numbersDisordered)));
Console.WriteLine("Selection sort " + string.Join("\t", SelectionSort.Handle(numbersDisordered)));
