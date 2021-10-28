using System;

public class Class1
{
	public Class1()
	{
		Console.WriteLine("Здравствуйте! Это программа по поиску максимального из 3-х чисел.");

		Console.Write("Введите первое число: ");
		float a = Convert.ToSingle(Console.ReadLine());

		Console.Write("Введите второе число: ");
		float b = Convert.ToSingle(Console.ReadLine());

		Console.Write("Введите третье число: ");
		float c = Convert.ToSingle(Console.ReadLine());

		if (a > b < c)
        {
			Console.WriteLine("OK");
        }
	}
}
