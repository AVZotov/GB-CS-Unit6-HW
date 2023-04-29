double GetUserInput()
{
    double value;
    value = Convert.ToDouble(Console.ReadLine());

    return Math.Round(value, 2);
}

void PrintIntersection(double b1, double k1, double b2, double k2)
{
    if (b1 == b2 && k1 == k2)
    {
        Console.WriteLine("Two lines are equal, no intersections");
        
        return;
    }

    if (k1 == k2)
    {
        Console.WriteLine("Lines are parallel, no intersection");

        return;
    }

    double x=(b2-b1)/(k1-k2);
    double y=(k1*(b2-b1))/(k1-k2)+b1;
    Console.WriteLine($"Intersection in coordinates: x={x}, y={y}");
}

Console.Clear();
double b1, k1, b2, k2;
Console.Write("enter b1: ");
b1 = GetUserInput();
Console.Write("enter k1: ");
k1 = GetUserInput();
Console.Write("enter b2: ");
b2 = GetUserInput();
Console.Write("enter k2: ");
k2 = GetUserInput();
PrintIntersection(b1, k1, b2, k2);