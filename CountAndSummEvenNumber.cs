using System;

public class Class1
{
	public Class1()
	{
		Console.WriteLine("Эта программа подсчитывает количества и сумму парных чисел в диапазоне от 1 до N.");
		Console.Write("Введите n - ");
		int n = Convert.ToInt32(Console.ReadLine());
		int summ = 0;
		int count = 0;

		for (int i = 2; i <= n; i = i + 2)
        {
			count++;
			summ += i;
        }

		Console.WriteLine($"{count} - количество парных чисел в диапозоне от 1 до N");
		Console.WriteLine($"{summ} - сумма парных чисел в диапозоне от 1 до N");

		Console.ReadLine();
	}
}
