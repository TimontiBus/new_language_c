﻿// Напишите программу, которая выводит третью с начала цифру заданного 
// числа или сообщает, что третьей цифры нет.

// Полностью моё решение (рабочее)

//int num = 123;
//if (num > 99)
//{
//	while (num > 999)
//	{
//		num = num / 10;
//	}
//	int oct = (num % 10);
//	Console.Write(oct);
//}
//else
//{
//	Console.Write("Нет 3 цифры");
//}

// Решение с преподаватетелем

int num = 123;
if (num > 99)
{
	while (num > 999)
	{
		num /= 10;
	}
	Console.Write($"Third digit is {num % 10}");
}
else
{
	Console.Write("Нет 3 цифры");
}