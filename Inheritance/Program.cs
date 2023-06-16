// See https://aka.ms/new-console-template for more information

using System;


Console.WriteLine("Enter Length:");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Width:");
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Height:");
int height = Convert.ToInt32(Console.ReadLine());

var cube = new Cube(width, height, length);

var triangle = new Triangle();
var triangle2 = new Triangle() { Height = height, Length = length, Hypotenuese = 10 };
var triangle1 = new Triangle(10);
var triangle3 = new Triangle(10, height, length);


var rectangle = new Rectangle() { Width = width, Length = length,  };


Console.WriteLine("Cube Area Is: " + cube.GetArea());
Console.WriteLine("Cube Volume Is: " + cube.getVolume());

Console.WriteLine("Traingle Area Is " + triangle.GetArea());
Console.WriteLine("Traingle Area Is " + triangle1.GetArea());
Console.WriteLine("Traingle Area Is " + triangle2.GetArea());
Console.WriteLine("Traingle Area Is " + triangle3.GetArea());

Console.WriteLine("Reactagle Area Is " + rectangle.GetArea());