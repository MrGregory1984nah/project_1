Консоль.Write("Сколько элементов Вы хотите ввести? ");
Преобразовать  =  размер  int.ToInt32(консоль.ReadLine());
строка[] arrayStrings = новая  строка[размер];
для (int  i = 0; i < size; i++)
{
    Консоль.WriteLine($"Введите {i+1}-й элемент: ");
    Преобразовать = строка элемента .toString(консоль.ReadLine());
    arrayStrings[i] = элемент;
}
строка[] arrayFinal = новая  строка[размер];
3 = len int;
0 =  pos  int;

для (int  j = 0; j < size; j ++)
{
    если (arrayStrings[j].Длина <= len)
    {
        arrayFinal[pos] = arrayStrings[j];
        ++pos;
    }
}
Консоль.WriteLine();
printArray(arrayFinal);
