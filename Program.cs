// -----------------------------------Домашнее задание----------------------------------------------
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.
// -------------------------------------------------------------------------------------------------

// Сгенерируем одномерный массив строк, для этого введем:

// Метод общения с пользователем 
int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод генерации строки псевдослучайного размера
string StringGenMethod(int minValue, int maxValue)
{
    string alphabet = "abcdefghijklmnopqrstuvwxyz";
    string result = "";
    Random len = new Random();
    int length = len.Next(minValue, maxValue);
    for (int i = 0; i < length; i++)
    {
        Random len2 = new Random();
        int x = len2.Next(26);
        result = result + alphabet[x];
    }
    return result;
}

// генерируем массив с заданной длиной и наполняем его случайными строками
string[] GenArray(int arrayLength, int minValue, int maxValue)
{
    string[] array = new string[arrayLength];

    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = StringGenMethod(minValue, maxValue);
    }
    return array;
}

// метод принимает на вход массив и выводит на экран
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
    Console.WriteLine();
}

// метод принимает на вход массив строк и выдает массив строк с длиной не более 3 символов
void PrintNewArray(string[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i].Length <= 3) Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
    Console.WriteLine();
}

int minVal = ReadData("Введите нижнюю границу длины строки: ");
int maxVal = ReadData("Введите верхнюю границу длины строки: ");
int arrLen = ReadData("Введите длину исходного массива строк: ");

string[] arr = GenArray(arrLen, minVal, maxVal);
Console.WriteLine();

Console.WriteLine("Исходный сгенерированный массив строк: ");
PrintArray(arr);

Console.WriteLine("Массив строк имеющих длину не более 3 символов: ");
PrintNewArray(arr);