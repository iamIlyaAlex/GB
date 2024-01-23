// Массивы!!! Урок2 - 2-Лекция

int[] arr = new int[5]; // new int[5] - выделение памяти
arr[0] = 1; // array - имя, 1,3,5,7,9 - элементы массива
arr[1] = 3; // [0], [1], [2], [3], [4] - индекс массива
arr[2] = 5;
arr[3] = 7;
arr[4] = 9;
Console.WriteLine(arr[0]);
Console.WriteLine(arr[1]);
Console.WriteLine(arr[2]);
Console.WriteLine(arr[3]);
Console.WriteLine(arr[4]);

int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };

int[] arr3 = { 1, 2, 3, 4, 5 } // можно не использовать "new int[5]" - так как нам известно, 
                               // сколько элементов,  и для создания небольших массивов