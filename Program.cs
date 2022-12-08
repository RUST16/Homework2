//Домашняя работа 2.

// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
 
/*
Console.Write("Введите число ");
int Number = Convert.ToInt32(Console.ReadLine());
string CutNumber = Convert.ToString(Number);
Console.WriteLine($"Вторая цифра числа - " + CutNumber[1] );
*/


// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
Console.Write("Введите число ");
int Number = Convert.ToInt32(Console.ReadLine());
string CutNumber = Convert.ToString(Number);

if(CutNumber.Length > 2)
{
    Console.WriteLine("Третья цифра числа = " + CutNumber[2]);
}

else 
{
    Console.WriteLine("Третьей цифры нет ");
}
*/
    

//Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет является ли этот день выходным

/*
Console.Write ("Введите число дня недели, а я вам скажу выходной это или нет: ");
int WeekDay = Convert.ToInt32(Console.ReadLine());

if(WeekDay <= 5)
{
    Console.WriteLine("Нет, это не выходной ");
}

if(WeekDay >= 6 && WeekDay <= 7)
{
     Console.WriteLine("Да, это выходной ");
}

if(WeekDay > 7)
{
    Console.WriteLine("Это вообще не день недели ");
}
*/
