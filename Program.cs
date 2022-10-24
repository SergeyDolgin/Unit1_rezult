// Функция для ввода с экрана массива пользователя
string [] Massive (int n)
{
    string []array = new string[n];
    for (int i=0; i<n; i++)
    {
        Console.Write($"Введите {i}-элемент ");
        array [i] = Console.ReadLine();
    }
    return array;
}
// Метод для вывода на экрана массива 
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
// Метод для определения элекментов массива, длина которых меньше или равна 3 символа
void FuncLess3(string[] YourMassive, string[] ResultMassive)
{
    int count = 0;
    for (int i = 0; i < YourMassive.Length; i++) 
    {
    if(YourMassive[i].Length <= 3)
        {
        ResultMassive[count] = YourMassive[i];
        count++;
        }
    }
}

System.Console.Write("Введите размерность вашего массива = ");
int n = Convert.ToInt32(Console.ReadLine());
string [] YourMassive = Massive (n); 
PrintArray(YourMassive);
string[] ResultMassive = new string[n];
FuncLess3(YourMassive, ResultMassive);
System.Console.Write("Элементы, длина которых меньше или равна 3 символа, из вашего массива это: ");
PrintArray(ResultMassive);

