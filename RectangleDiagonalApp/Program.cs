namespace RectangleDiagonalApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RectangleDiagonalApp!");
            Console.WriteLine("\r");
            double rectangleWidth = 5;
            double rectangleHeight = 7;
            double rectangleDiagonal = Math.Sqrt(Math.Pow(rectangleWidth, 2) + Math.Pow(rectangleHeight, 2));
            Console.WriteLine($"The length of the diagonal of a rectangle with dimensions {rectangleWidth} and {rectangleHeight} is: {rectangleDiagonal}");
        }
    }
}