namespace R.Operator.Overload;

public class Box(int length, int width, int height)
{
    private int Length { get; } = length;
    private int Width { get; } = width;
    private int Height { get; } = height;

    public static Box operator +(Box boxLeft, Box boxRight)
    {
        return new Box(
            boxLeft.Length + boxRight.Length,
            boxLeft.Width + boxRight.Width,
            boxLeft.Height + boxRight.Height);
    }

    public override string ToString() => $"{Length} x {Width} x {Height}";
}