﻿Console.WriteLine("Введите количество элиментов массива");
int N = Convert.ToInt32(Console.ReadLine());
int i;
Console.WriteLine("Mассив:");
string [] array = new string [N];

  for(i=0; i<N; i++){
        Console.WriteLine($"Введите элимент массива с индексом {i}");
        array[i] = Console.ReadLine();        
}
