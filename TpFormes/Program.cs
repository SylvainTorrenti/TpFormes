﻿using TpFormes;
#region Creation des objets
Drawing d1 = new Drawing();
Point p1 = new Point(1, 1);
Point p2 = new Point(2, 2);
Segment s1 = new Segment(p1, p2);
Circle c1 = new Circle(p2, 6);
Circle c2 = new Circle(p2, 8);
Circle c3 = new Circle(p2, 10);
Circle c4 = new Circle(p2, 12);
Rectangle r1 = new Rectangle(p1, 5, 2); 
#endregion
//Console.WriteLine(c1.ToString());
//Console.WriteLine($"Le perimetre du cercle est : {c1.GetPerimetre()}");
//Console.WriteLine("--------------------------------");
//Console.WriteLine($"La surface du cercle est : {c1.GetSurface()}");
//Console.WriteLine("--------------------------------");
//Console.WriteLine(r1.ToString());
//Console.WriteLine($"Le perimetre du rectangle est : {r1.GetPerimetre()}");
//Console.WriteLine("--------------------------------");
//Console.WriteLine($"La surface du rectangle est : {r1.GetSurface()}");
d1.AddForm(c4);
d1.AddForm(r1);
d1.AddForm(c1);
d1.AddForm(c2);
d1.AddForm(c3);
d1.SortList();
d1.AfficherLaListeDeForme();

