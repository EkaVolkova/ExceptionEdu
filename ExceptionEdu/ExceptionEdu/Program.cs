using System;

/// <summary>
/// 9.1.3 Создайте класс исключения Exception и добавьте в свойство Data дату создания исключения.
/// 9.1.4Создайте класс исключения Exception и переопределите его свойство Message, 
/// а также свойство HelpLink, добавив в него ссылку на внешний ресурс.
/// </summary>
namespace ExceptionEdu
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception exception = new Exception("Исключение!");
            exception.Data.Add("Дата создания исключения: ", DateTime.Now);
            exception.HelpLink = @"https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/";
        }
    }
}
