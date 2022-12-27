// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,  длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучшеstring[] array1 = new string[5] {"123", "23", "hello", "world", "res"};

Console.WriteLine("введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
string[] arr = new string[array.Length];
string stopWord = "stop";
void poisk (string [] array, string [] arr){

for (int i = 0; i < size; i++)
{
    Console.WriteLine($"введите слово № {i + 1}, если ошиблись наберите stop и запустите программу заново");
    array[i] = Console.ReadLine();
    if (array[i]== stopWord){
        break;
    }

}
Console.WriteLine(string.Join(", ", array));



int count = 0;

for (int i = 0; i < size; i++)
{
    if (array[i].Length <= 3)
    {

        arr[count] = array[i];
        count++;

    }
  
}
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

poisk(array,arr);
PrintArray(arr);