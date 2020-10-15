using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GTSP_2
{
    class Edge
    {
        private Line Drawable { get; }
        Vertex source;
        Vertex dest;

        public Edge(Vertex source, Vertex dest)
        {
            this.source = source;
            this.dest = dest;
            Drawable = CreateInitialLine();
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
    }
}
