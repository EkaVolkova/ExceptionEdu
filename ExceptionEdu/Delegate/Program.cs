﻿using System;

/// <summary>
/// 9.3.2 Создайте консольное приложение, в котором есть функция, принимающая на вход два числа int, 
/// и возвращающая результат int вычитания второго числа из первого. 
/// Вызовите эту функцию в классе Main при помощи делегата и отобразите результат в консольном сообщении.
/// 
/// 9.3.3 Используя ваше приложение из задания 9.3.2, реализуйте вызов делегата двумя разными способами.
/// </summary>
namespace Delegate
{
    class Program
    {
        delegate int SubstractDelrgate(int a, int b);
        static void Main(string[] args)
        {
            SubstractDelrgate substractDelrgate = Substract;
            Console.WriteLine(substractDelrgate.Invoke(1, 2));
            Console.WriteLine(substractDelrgate(1, 2));

        }
        static int Substract(int a, int b)
        {
            return a - b;
        }
    }
}
