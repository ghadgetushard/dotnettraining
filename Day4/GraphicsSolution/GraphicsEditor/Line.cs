namespace Drawing;

public class Line : Shape, IDisposable
{
    public Point Start { get; set; }

    public Point End { get; set; }

    public Line() {
        Start = new Point();
        End = new Point();
    }

    public Line(Point start, Point end, Color color, int thickness) {
        Start = start;
        End = end;
        Color = color;
        Thickness = thickness;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a {shapeColor} line from {Start} to {End} with Thickness {Thickness}");
    }

    // Destructor : its anutomatically invoked by garbage collector
    //Indeterministic finalisation 
    ~Line()
    {
        // Connection Loose
        // Socket close
        // Release resources which are acquired during the lifetime of the object
        // Clean up if necessary
    }

    public void Dispose()
    {
        // call Dispose on any IDisposable members
        GC.suppressFinalize(this); // suppressFinalize is static method of class GC.
    }

}