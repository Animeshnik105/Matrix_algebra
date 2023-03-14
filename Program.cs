// See https://aka.ms/new-console-template for more information
Console.WriteLine("Вы открыли приложение <<Матричная алгебра>> для работы с матрицами\n\nНапоминание:\nВведение матриц осуществляется построчно через нажатие кнопки <<Пробел>>\n\nСписок команд:\n1 - сложение\n2 - вычитание\n3 - умножение на число\n4 - транспонирование\n5 - умножение на транспонированную матрицу\n6 - перестановка двух строк матрицы\n7 - перестановка матрицы согласно вектору\n8 - обратная матрица\n");
while (0 == 0)
{
	Console.Write("\nВыберите действие нажав соответствующую цифру: ");
	int action = Convert.ToInt32(Console.ReadLine());
	if (action == 1)
	{
		Console.WriteLine("\nВведение первой матрицы");
		Console.Write("Введите количество строк: ");
		int line = Convert.ToInt32(Console.ReadLine());
		Console.Write("Введите количество столбцов: ");
		int column = Convert.ToInt32(Console.ReadLine());
		if (line == column)
		{
			Console.Write("Количество строк и столбцов не должно быть равно!");
			break;
		}
		Console.WriteLine("Введите матрицу: ");
		int[,] array = new int[line, column];
		for (int i = 0; i < line; ++i)
        {
			string a = Console.ReadLine();
			int[] b = a.Split(' ').Select(int.Parse).ToArray();
			for (int j = 0; j < column; ++j)
            {
				array[i, j] = b[j];
            }
        }
		Console.WriteLine("\nВведение второй матрицы");
		Console.Write("Введите количество строк: ");
		int line2 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Введите количество столбцов: ");
		int column2 = Convert.ToInt32(Console.ReadLine());
		if (line2 == column2)
        {
			Console.Write("Количество строк и столбцов не должно быть равно!");
			break;
        }
		Console.WriteLine("Введите матрицу: ");
		int[,] array2 = new int[line2, column2];
		for (int i = 0; i < line2; ++i)
		{
			string a = Console.ReadLine();
			int[] b = a.Split(' ').Select(int.Parse).ToArray();
			for (int j = 0; j < column2; ++j)
			{
				array[i, j] = b[j];
			}
		}
		
	}
	if (action == 2)
	{

	}
	if (action == 3)
	{

	}
	if (action == 4)
	{

	}
	if (action == 5)
	{

	}
	if (action == 6)
	{

	}
	if (action == 7)
	{

	}
	if (action == 8)
	{

	}
}

