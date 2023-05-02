// Console.WriteLine("Input number:");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Your input {num} number");

// Task1. запросить число и вывеси его квадрат.

// Console.WriteLine("Input number:");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Quad of {num} -> {num*num}");

// Task2. Является ли первое число кваадратом второго?

// Console.WriteLine("Input first number:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 == num2*num2)
// {
//     Console.WriteLine($"{num1} является квадратом {num2}");
// }
// else
// {
//     Console.WriteLine($"{num1} не является квадратом {num2}");
// }

// Task3. Напишите программу, которая принимает на вход число N, а на выходе получаем последовательность от -N до N.

// Console.WriteLine("Input N:");
// int N = Convert.ToInt32(Console.ReadLine());

// if(N<0) Console.WriteLine("Invalid input N");

// int count = N*(-1);
// while(count <= N)
// {
//     Console.Write(count+" ");
//     count++;

// }

//Task4. На вход принимаем 3х значное число, вывести последнюю цифру данного числа.

// Console.WriteLine("Input three-digit number:");
// int n = Convert.ToInt32(Console.ReadLine());

// int ed = n % 10;
// Console.WriteLine($"Last digit of {n} -> {ed}");


// Домашнее задание:
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Input a:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input b");
// int b = Convert.ToInt32(Console.ReadLine());

// if(a <= b)
// {
//     Console.WriteLine($"a = {a}; b = {b} -> max = {b}");
// }
// else
// {
//     Console.WriteLine($"a = {a}; b = {b} -> max = {a}");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Input numbers:{num1}, {num2}, {num3}");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());

// {
//     if(num1 > num2)
//     {
//         {
//         if(num2 > num3)
//         Console.WriteLine($"max = {num1}");
//         }
    

//     if(num1 < num2)
//         {
//         if(num2 < num3)
//         Console.WriteLine($"max = {num3}");
//         }
//     }


//     else 
//     {
//         Console.WriteLine($"max = {num2}");
//     }
// }

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Input number:");
// int num = Convert.ToInt32(Console.ReadLine());

// {
//     if (num % 2 == 0)
//     {
//         Console.WriteLine($"True");
//     }

//     else
//     {
//         Console.WriteLine($"False");
//     }
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.WriteLine("Input number:");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num%2 == 1) Console.WriteLine("{num} -> 2");

// int count = 2;
// while(count <= num)
// {
    
//     {
//         Console.Write(count+" ");
//         count = count +2;
//     }
// }
