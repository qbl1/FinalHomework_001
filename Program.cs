string[] ArrayStr(string[] array){
    int size = array.Length;
    string[] array2 = new string[size];             // get size
    int count = 0;
    for(int i = 0; i < size; i++){                  // main cycle for source condition
        if (array[i].Length <= 3){
            array2[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref array2, count);                // remove unnecessary items of array
return array2;
}

void PrintArray(string[] array){                    // function for print 1d array
    for (int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string[] array = { "Hello", "2", "world", ":-)" };
string[] ResultArray = ArrayStr(array);
PrintArray(ResultArray);