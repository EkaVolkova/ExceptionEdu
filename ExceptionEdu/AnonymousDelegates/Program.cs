using System;

/// <summary>
/// Существует следующее консольное решение, которое отображает сообщение Hello World в консольном сообщении:
///     delegate void ShowMessageDelegate(string _message);
///     static void Main(string[] args)
///     {
///         ShowMessageDelegate showMessageDelegate = ShowMessage;
///         showMessageDelegate.Invoke("Hello World!");
///         Console.Read();
///     }
///     static void ShowMessage(string _message)
///     {
///         Console.WriteLine(_message);
///     }
///     Реализуйте в данном решении анонимный метод, не сломав логику приложения.
/// </summary>
namespace AnonymousDelegates
{
    class Program
    {
        delegate void ShowMessageDelegate(string _message);
        static void Main(string[] args)
        {
            ShowMessageDelegate showMessageDelegate = delegate(string _message)
            {
                Console.WriteLine(_message);
                
            };
            showMessageDelegate.Invoke("Hello World!");
            Console.Read();
        }

    }
}
