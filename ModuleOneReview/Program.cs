namespace ModuleOneReview;

class Program
{
    public static double CircleArea(double radius)  //Method for circle area
    {
        return Math.PI * radius * radius;          //Circle area formula
    }

    public static double TriangleArea(double baseLength, double heightOne)     //Method for triangle
    {
        return ((.5) * baseLength) * heightOne;                               //Triangle area formula
    }
    
    public static double RectangleArea(double length, double width)     //Rectangle area method
    { 
        return length * width;                                          //Rectangle area formula
    }

    public static double SquareArea(double side)        //Method for square
    {
        return side * side;                             //Square area formula
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, please enter a radius to find the area of a circle.");  //Initial question
        
        Console.Write("Enter radius: ");                //Showing what I'm asking for
        
        string? radiusInput = Console.ReadLine();      //Asking for user input to console
        double radius;                                 //Declares radius as number

            if (Double.TryParse(radiusInput, out radius))                             //Convert string input to Int
            {
            Console.WriteLine($"The area of the circle is: {CircleArea(radius)}");    //Call circle method
            }
        
        Console.WriteLine("Please enter the base, and then the height, to find the area of a triangle.");
        
        Console.Write("Base: ");
        string? baseInput = Console.ReadLine();
        
        Console.Write("Height: ");
        string? heightInput = Console.ReadLine();

        double baseOne, height = 0;                // = 0 so height can be initialized
        
            if (Double.TryParse(baseInput, out baseOne) && Double.TryParse(heightInput, out height));
            {
                Console.WriteLine($"The area of the triangle is: {TriangleArea(baseOne, height)}");
            }
        
        
        
       
        
        //string? lengthInput=Console.ReadLine();
       // string? widthInput = Console.ReadLine();
        
        
        
       // Console.WriteLine($"Rectangle Area: {RectangleArea()}");   //Call rectangle method
        
       //3
       //string? sideInput = Console.ReadLine();
        
       
        
        //Console.WriteLine($"Square Area: {SquareArea()}");          //Call square method
    }
}