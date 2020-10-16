using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GTSP_2
{
    public class Edge
    {
        public Line Drawable { get; }
        public Vertex source { get; }
        public Vertex dest { get; }

        public Edge(Vertex source, Vertex dest, Canvas canvas)
        {
            this.source = source;
            this.dest = dest;
            Drawable = CreateInitialLine();
            canvas.Children.Add(Drawable);
        }

        private Line CreateInitialLine()
        {
            return new Line
            {
                Stroke = Brushes.AliceBlue,
                X1 = source.Position.X,
                Y1 = source.Position.Y,
                X2 = dest.Position.X,
                Y2 = dest.Position.Y
            };
        }

        public void Log()
        {
            Debug.WriteLine($"Line pos: ({0}, {1}), ({2}, {3})", Drawable.X1, Drawable.Y1, 
                Drawable.X2, Drawable.Y2);
        }
    }
}
