//--------ЗАДАЧА--------

void Task(){
    string[] arrayFirst = {"qwert", "asd", "12", "9876", ":-)"};
    Console.WriteLine("Первоначальный массив");
    PrintArray(arrayFirst);

    string fill = string.Empty;
    fill = SortSymbol(arrayFirst, fill);

    string[] arraySecond = {fill};
    Console.WriteLine("Изменённый массив");
    PrintArray(arraySecond);
}

//--------МЕТОДЫ--------

void PrintArray(string[] array){
    int size = array.Length;
    for(int i = 0; i < size; i++){
        Console.Write(array[i] + ", ");
    }
    Console.Write("\b\b ");
    Console.WriteLine();
}

string SortSymbol(string[] array, string fill){
    int size = array.Length;
    for(int i = 0; i < size; i++){
        if(array[i].Length <= 3){
            fill += array[i] + ", ";
        }
    }
    fill = fill.Remove(fill.Length - 2);
    return fill;
}

//--------ВЫВОД РЕШЕНИЯ--------

Task();
