namespace ModuleOneReview;

class Program
{
    public static double CircleArea(double radius)  //Method for circle area
    {
        return Math.PI * radius * radius;           //Circle area formula
        string radiusInput = Console.ReadLine();
        
    }

    public static double TriangleArea(double baseLength, double height)     //Method for triangle
    {
        return ((.5) * baseLength) * height;                               //Triangle area formula
    }
    
    public static double RectangleArea(double length, double width)     //Rectangle area method
    { 
        return length * width;                                          //Rectangle area formula
    }

    public static double SquareArea(double side)                       //Method for square
    {
        return side * side;                                            //Square area formula
    }
   
    static void Main(string[] args)
    {
        Console.WriteLine("Circle Area: " + CircleArea((10)));  //Call circle ara method
        Console.WriteLine($"Triangle area: {TriangleArea(3,2)}");  //Call triangle method
        Console.WriteLine($"Rectangle Area: {RectangleArea(3,2)}");   //Call rectangle method
        Console.WriteLine($"Square Area: {SquareArea(3)}");
    }
}