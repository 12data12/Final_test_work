
Console.WriteLine ("Enter a space-separated string array: "); // Введите массив строк, разделенных пробелом 
string[] array = Console.ReadLine()!.Split(' '); // Считывание введенного массива и заполнение массива с разделением на подстроки и исключением null значений 
string[] result = new string[array.Length]; // Массив для вывода результата 

for (int i = 0; i < array.Length; i++) // Цикл начинается с индекса 0 и работает с шагом 1 до тех пор, пока индекс элемента меньше длины массива
{
    if (array[i].Length <= 3 && !string.IsNullOrWhiteSpace(array[i])) // Проверка длины строки и наличия пустых элементов в строке
    Console.Write (result[i] = array[i] + " "); // Вывод результата
}