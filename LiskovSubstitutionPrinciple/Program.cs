using LiskovSubstitutionPrinciple.Models;

var square = new Square
{
    Height = 40,
    Width = 40
};

var area = square.Area();
Console.WriteLine($"The area of the square is {area}.");