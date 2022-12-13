// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// void Palindrome(int number)
// {
//     if (number > 9999 && number < 100000)
//     {
//         int numb = 0;
//         int number1 = number;

//         for (int count = 5; count > 0; count--)
//         {
//             numb = numb * 10 + (number1 % 10);
//             number1 = number1 / 10;
//         }
//         if (numb == number)
//         {
//             Console.WriteLine("Введенное число является палиндромом");
//         }
//         else 
//         {
//             Console.WriteLine("Введенное число не является палиндромом");
//         }
//     }
//     else 
//     {
//         Console.WriteLine("Вы ввели не пятизначное чиcло");
//     }
// }

// Console.Write("Введите пятизначное число:  ");
// int number = Convert.ToInt32(Console.ReadLine());
// Palindrome(number);





// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void TableOfCubes(int number)
// {
//     int result = 0;
//     Console.WriteLine($"Ваша таблица кубов от 1 до {number}");
//     for (int numb = 1; numb <= number; numb++)
//     {
//     result = numb * numb * numb;
//     Console.Write(result + " ");
//     }
// }
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// TableOfCubes(number);





// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
// {
    
//     double a = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1);
//     double b = Math.Sqrt(a);
//     return(b);
// }
// Console.Write("Введите x1 = ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите x2 = ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y1 = ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y2 = ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите z1 = ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите z2 = ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double res = Distance(x1, y1, z1, x2, y2, z2);
// Console.WriteLine($"Результат - {Math.Round(res,2)}");



