using System;
using LearnCollections;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(34.5);
            square.Display();
            Rectangle rectangle = new Rectangle(10, 20);
            rectangle.Display();

        }
    }
}
