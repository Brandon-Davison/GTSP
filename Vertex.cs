using System.Diagnostics;
using System.Windows;
using System.Windows.Shapes;

namespace GTSP_2
{
    public class Vertex
    {
        public Ellipse Drawable { get; }
        public Point Position { get; set; }

        public Vertex(Ellipse ellipse)
        {
            Drawable = ellipse;
        }

        public Vertex(Ellipse ellipse, Point point)
        {
            Drawable = ellipse;
            Position = point;
        }

        public void Log()
        {
            Debug.WriteLine($"Coordinates: {0}", Position);
        }
    }
}
