void FullMatrix1(int size, string[] matrix1)
//Заполняем массив
{
    int i = 0;
    while (i <= size - 1)
    {
        Console.Write($"Введите {i+1} элемент массива: ");     
        matrix1[i] = Convert.ToString(Console.ReadLine());  
        i++;
    }
    Console.WriteLine();
    Console.WriteLine("Получился массив строк:");
    Console.WriteLine($"[{string.Join(", ", matrix1)}]");
}

void RezultMatrix2(string[] matrix1, string[] matrix2)
//Сравниваем элементы массива и выводим новый с нужными элементами
{
    int i = 0;
    foreach (string value in matrix1)
    {
        if(value.Length <= 3)
        {
        matrix2[i] = value;
        i++;
        }
    }
    Console.WriteLine($"[{string.Join(", ", matrix2, 0, i)}]");
}


Console.Clear();
Console.Write("Укажите размер массива строк: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Задайте массив, состоящий из {size} элементов.");
string[] matrix1 = new string[size];
string[] matrix2 = new string[matrix1.Length];
FullMatrix1(size, matrix1);
Console.WriteLine();
Console.WriteLine("В заданном массиве длину меньше или равную трем символам имеют следующие элементы: ");
RezultMatrix2(matrix1, matrix2);