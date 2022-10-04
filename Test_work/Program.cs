Console.Clear();
Console.Write ("Enter a space-separated string array: "); // Введите массив строк, разделенных пробелом 
string[] array = Console.Readline() !.Split(' '); // Считывание введенного массива и заполнение массива с разделением на подстроки и исключением null значений 
string[] result = new string[array.Length]; // Массив для вывода результата 