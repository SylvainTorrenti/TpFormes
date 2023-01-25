using TpFormes;

Point p1 = new Point(1, 1);
Point p2 = new Point(2, 2);
Segment s1 = new Segment(p1, p2);
Circle c1 = new Circle(p2, 6);
Console.WriteLine(c1.ToString());
Console.WriteLine(c1.GetPerimetre());
Console.WriteLine(c1.GetSurface());

