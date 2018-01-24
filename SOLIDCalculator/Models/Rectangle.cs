namespace SOLIDCalculator.Models
{
    public class Rectangle
    {
        public double Width { get; private set; }
        public double Length { get; private set; }

        public Rectangle(double length, double width)
        {
            Width = width;
            Length = length;
        }
    }
}
