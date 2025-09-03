using Drawing;


using System.collection.Generic;
//Disposing Technique
// for (int i = 0; i <= 100; i++)
// {
// }
using (List <Line> lines = new List<Line>()) {

    Line l1 = new Line(new Point(12, 56), new Point(350, 100), Color.Red, 2);
    Line l2 = new Line(new Point(12, 56), new Point(350, 100), Color.Blue, 2);
    Line l3 = new Line(new Point(12, 56), new Point(350, 100), Color.Green, 2);
    // l1.Draw();
    // l2.Draw();
    // l3.Draw();

    lines.add(l1);
    lines.add(l2);
    lines.add(l3);

    // l1.Dispose();
    // l2.Dispose();
    // l3.Dispose();
}

Console.WriteLine("Hello, World!");
