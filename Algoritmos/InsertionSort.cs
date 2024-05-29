if(args.Length==0){
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

Console.WriteLine(string.Join("\t", numbersDisordered));
Console.WriteLine(string.Join("\t", InsertionSort(numbersDisordered)));

static int[] InsertionSort(int[] numbers){
    int initial;
    int index;
    for (int i = 0; i < numbers.Length; i++)
    {
        initial = numbers[i];
        index = i-1;
        while (index >= 0 && numbers[index] > initial){
            numbers[index + 1] = numbers[index];
            index--;
        }
        numbers[index+1] = initial;
    }
    return numbers;
}