/*/ Написать программу, которая из имеющегося массива целых 
чисел формирует массив из чисел, больших 8. Первоначальный 
массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
/*/
int[] array = new int[10];
Console.Write("Массив сгенерированный случайным образом - [ ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = (new Random().Next(1,20));
            Console.Write(array[i]+", ");
            }
            Console.Write("]");
            Console.WriteLine();
            Console.Write("Сформированный массив из чисел, больших 8 - [ ");
    for (int i = 0; i < array.Length; i++){
        if (array[i] > 8){
            Console.Write($"{array[i]}, " + string.Empty);}    
    }
    Console.Write("]"); 
            //картинка с блок схемой прилагается 222.jpg
                
                        
          