using System;

/// <summary>
/// 9.3.2 Создайте консольное приложение, в котором есть функция, принимающая на вход два числа int, 
/// и возвращающая результат int вычитания второго числа из первого. 
/// Вызовите эту функцию в классе Main при помощи делегата и отобразите результат в консольном сообщении.
/// 
/// 9.3.3 Используя ваше приложение из задания 9.3.2, реализуйте вызов делегата двумя разными способами.
/// 9.3.4 Реализуйте консольное приложение, в котором существует две функции: 
/// первая функция вычитает второе число из первого и отображает результат в консольном сообщении, 
/// вторая функция складывает два числа и отображает результат в консоли. 
/// Реализуйте вызов этих двух функций через многоадресный делегат.
/// </summary>
namespace Delegate
{
    class Program
    {
        delegate void CalculateDelegate(int a, int b);
        static void Main(string[] args)
        {
            CalculateDelegate calculateDelegate = Substract;
            calculateDelegate += Sum;
            calculateDelegate.Invoke(2, 1);

        }
        static void Substract(int a, int b)
        {

            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }

        static void Sum(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
    }
}
