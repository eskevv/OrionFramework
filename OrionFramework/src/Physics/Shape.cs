using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace OrionFramework.Physics;

public class Shape
{
    public ShapeType Type { get; set; }
}

public class CircleShape : Shape
{
    public float Radius { get; set; }

    public CircleShape(float radius)
    {
        Type = ShapeType.Circle;
        Radius = radius;
    }
}

public class PolygonShape : Shape
{
    private List<Vector2> _vertices;

    public PolygonShape(List<Vector2> vertices)
    {
        Type = ShapeType.Polygon;
        _vertices = vertices;
    }
}

public class BoxShape : Shape
{
    private List<Vector2> _vertices;
    public int Width { get; set; }
    public int Height { get; set; }

    public BoxShape(int width, int height)
    {
        _vertices = new List<Vector2>();
        Type = ShapeType.Box;
        Width = width;
        Height = height;
    }
}