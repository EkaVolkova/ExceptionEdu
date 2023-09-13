using System;

/// <summary>
/// 9.1.3 Создайте класс исключения Exception и добавьте в свойство Data дату создания исключения.
/// </summary>
namespace ExceptionEdu
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception exception = new Exception();
            exception.Data.Add("Дата создания исключения: ", DateTime.Now);
        }
    }
}
