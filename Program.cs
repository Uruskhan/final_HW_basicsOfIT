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

int minVal = ReadData("Введите нижнюю границу длины строки: ");
int maxVal = ReadData("Введите верхнюю границу длины строки: ");

Console.WriteLine(StringGenMethod(minVal,maxVal));