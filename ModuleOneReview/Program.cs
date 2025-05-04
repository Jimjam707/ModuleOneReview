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
        Console.WriteLine("Please enter a number for the radius to find the area of a circle");  //Initial question
        
        Console.Write("Enter radius: ");                //Showing what I'm asking for
        
        string? radiusInput = Console.ReadLine();      //Asking for user input to console
        double radius;                                 //Declares radius as number

            if (Double.TryParse(radiusInput, out radius))                             //Convert string input to double
            {
            Console.WriteLine($"The area of the circle is: {CircleArea(radius)}");    //Call circle method
            }
        
        Console.WriteLine("Please enter a number for  the base, and then the height, to find the area of a triangle");
        
        Console.Write("Base: ");
        string? baseInput = Console.ReadLine();
        
        Console.Write("Height: ");
        string? heightInput = Console.ReadLine();

        double baseOne, height = 0;                // = 0 to be initialized
        
            if (Double.TryParse(baseInput, out baseOne) && Double.TryParse(heightInput, out height));
            {
                Console.WriteLine($"The area of the triangle is: {TriangleArea(baseOne, height)}");
            }
            
        Console.WriteLine("Please enter a number for the length and for the width to find the area of a rectangle");
        
        Console.Write("Length: ");
        string? lengthInput = Console.ReadLine();
        
        Console.Write("Width: ");
        string? widthInput = Console.ReadLine();

        double length, width = 0;                   // = 0 to be initialized

            if (Double.TryParse(lengthInput, out length) && Double.TryParse(widthInput, out width)) ;
            {
                Console.WriteLine($"The area of the rectangle is: {RectangleArea(length, width)}");
            }
        
        Console.WriteLine("Please enter a number for a side to find the area of a square");
        
        Console.Write("Side: ");
        string? sideInput = Console.ReadLine();

        double side;
        
            if (Double.TryParse(sideInput, out side))
            {
                Console.WriteLine($"The area of the square is: {SquareArea(side)}");
            }

                    //Probably could have made it shorter, but this was how I knew it would work with my experience.  Feedback is greatly appreciated.


        
    }
}