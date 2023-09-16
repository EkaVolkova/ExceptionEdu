using System;

/// <summary>
/// 9.2.3Создайте консольное решение, в котором реализуйте конструкцию Try/Catch/Finally для обработки исключения RankException. 
/// В случае исключения отобразите в консоль тип исключения (через метод GetType()).
/// </summary>
namespace TryCatchRankException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new RankException("Ошибка");
            }
            catch(RankException ex)
            {
                Console.WriteLine(ex.GetType());
            }
            finally
            {

            }
        }
    }
}
