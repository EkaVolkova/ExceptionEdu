using System;

/// <summary>
/// Создайте консольное приложение, в котором реализуйте демонстрацию ковариантности делегатов при помощи следующей модели классов:
/// class Car {}
/// class Lexus : Car { }
/// </summary>
namespace Covariance
{
    class Program
    {
        delegate Car Handler();
        static void Main(string[] args)
        {
            Handler handlerCar = HandlerCar;
            Handler handlerLexus = HandlerLexus;
        }
        static Car HandlerCar()
        {
            return new Car();
        }
        static Lexus HandlerLexus()
        {
            return new Lexus();
        }

    }
    class Car { }
    class Lexus : Car { }

}
