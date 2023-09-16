using System;

/// <summary>
/// На основе скринкаста создайте консольное приложение, в котором реализуйте демонстрацию контравариантности делегатов при помощи следующей модели классов:
/// class Parent { }
/// class Child : Parent { }
/// </summary>
namespace Contravariance
{
    class Program
    {
        delegate void Handler(Child child);
        static void Main(string[] args)
        {
            Handler handlerChild = HandlerChild;
            Handler handlerParent = HandlerParent;
        }
        static void HandlerParent(Parent parent)
        {
            
        }
        static void HandlerChild(Child child)
        {
        }
    }
    class Parent { }
    class Child : Parent { }
}
