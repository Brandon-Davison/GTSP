using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
