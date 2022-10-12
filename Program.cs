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

string[] GenArray(int arrayLength, int minValue, int maxValue) // генерируем массив с заданной длиной
{
    string[] array = new string[arrayLength]; // выделяем память для нового массива с заданной длиной  

    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = StringGenMethod(minValue, maxValue);
    }
    return array;
}

void PrintArray(string[] array) // принимает на вход массив и выводит на экран
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
    Console.WriteLine();
}

int minVal = ReadData("Введите нижнюю границу длины строки: ");
int maxVal = ReadData("Введите верхнюю границу длины строки: ");
int arrLen = ReadData("Введите длину массива строк: ");

string[] arr = GenArray(arrLen, minVal, maxVal);
PrintArray(arr);