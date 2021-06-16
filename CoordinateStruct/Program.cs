using System;

namespace CoordinateStruct
{
    class Program
    {
        struct Coordinate
        {
            public int FirstCoord { get; set; }
            public int SecondCoord { get; set; }
            public Coordinate(int firstCoord, int secondCoord)
            {
                FirstCoord = firstCoord;
                SecondCoord = secondCoord;
            }
            public int Sum(int x, int y)
            {
                return x + y;
            }
            public int Subtract(int x, int y)
            {
                return x - y;
            }
            public int Multiply(int x, int y)
            {
                return x * y;
            }
            public int Divide(int x, int y)
            {
                return y != 0 ? x/y : 0;
            }
            public enum Action 
            { 
                Sum, 
                Subtract, 
                Multiply, 
                Divide 
            }
           
            public void Print(Action action, int x, int y)
            {
                switch (action)
                {
                    case Action.Sum:
                        Console.WriteLine($"Sum is: {Sum(x, y)}" );
                        break;
                    case Action.Subtract:
                        Console.WriteLine($"Subtract is: {Subtract(x, y)}");
                        break;
                    case Action.Multiply:
                        Console.WriteLine($"Multiply is: {Multiply(x, y)}");
                        break;
                    case Action.Divide:
                        Console.WriteLine($"Division is: {Divide(x, y)}");
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Input first number: ");
            int y = int.Parse(Console.ReadLine());

            Coordinate coordinate = new Coordinate();

            coordinate.Print(Coordinate.Action.Sum, x, y);
            coordinate.Print(Coordinate.Action.Subtract, x, y);
            coordinate.Print(Coordinate.Action.Multiply, x, y);
            coordinate.Print(Coordinate.Action.Divide, x, y);
        }
    }
}
