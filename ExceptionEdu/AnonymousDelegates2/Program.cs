using System;

/// <summary>
/// Существует консольное решение, которое выводит случайное целое число в диапазоне от 0 до 100 и отображает результат в консольное сообщение:
///     class Program
///     {
///         delegate int RandomNumberDelegate();
///         static void Main(string[] args)
///         {
///             RandomNumberDelegate randomNumberDelegate = RandomNumber;
///             int result = randomNumberDelegate.Invoke();
///             Console.WriteLine(result);
///             Console.Read();
///         }
///         
///         static int RandomNumber()
///         {
///             return new Random().Next(0, 100);
///         }         
///     }
///     
/// Реализуйте в данном решении анонимный метод, не сломав логику приложения.
/// 9.3.15 Реализуйте лямбда-оператор во время вызова анонимного метода.
/// </summary>
namespace AnonymousDelegates2
{
    class Program
    {
        delegate int RandomNumberDelegate();
        static void Main(string[] args)
        {
            RandomNumberDelegate randomNumberDelegate = () => new Random().Next(0, 100);
            int result = randomNumberDelegate.Invoke();
            Console.WriteLine(result);
            Console.Read();
        }

    }
}
