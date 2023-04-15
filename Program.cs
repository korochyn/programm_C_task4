// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
int count =1;
while (count <= number)
                    {
                    int result_1 = count / 2;
                    int result_2 = count - result_1*2;
                    if (result_2 == 0) {Console.WriteLine(count);}
                    count = count + 1;                  
                    }


