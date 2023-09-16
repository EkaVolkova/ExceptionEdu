using System;

/// <summary>
/// Создайте консольное решение, в котором реализуйте конструкцию Try/Catch/Finally для обработки исключения ArgumentOutOfRangeException.
/// В случае исключения отобразите в консоль сообщение об ошибке.
/// </summary>
namespace TryCatchArgumentOutOfRangeException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new ArgumentOutOfRangeException("Сообщение об ошибке");

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
        }
    }
}
