using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GTSP_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Canvas canvas;

        // Needed to move shapes around canvas
        protected bool isDragging = false;
        private Point clickPosition;
        private TranslateTransform originTT;

        // Maintains prev clicked Vertex for edge drawing
        private Object prevClickedVertex;

        /// <summary>
        /// Setup window and Canvas
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            canvas = new Canvas
            {
                Width = 400,
                Height = 400
            };
            this.Content = canvas;
            this.MouseLeftButtonDown += Window_OnMouseLeftClick;
        }

        /// <summary>
        /// Performs one of two operations
        /// 1) Place new vertex
        /// 2) Draw an edge between two vertices
        /// </summary>
        private void Window_OnMouseLeftClick(object sender, MouseButtonEventArgs e)
        {
            Point p = Mouse.GetPosition(canvas);
            Object obj = FindVertexSpenningPoint(p);

            if (obj == null)
            {
                // Place new Vertex; prevClicked = null; return;
            }

            if (prevClickedVertex != null)
            {
                // Draw edge
            }
            // prevClickedVertex = currVertex
        }

        /// <summary>
        /// Starts vertex drag
        /// </summary>
        private void Canvas_OnEllipseLeftClick(object sender, MouseButtonEventArgs e)
        {
            var draggableControl = sender as Shape;
            originTT = draggableControl.RenderTransform as TranslateTransform ?? new TranslateTransform();
            isDragging = true;
            clickPosition = e.GetPosition(this);
            draggableControl.CaptureMouse();
        }

        /// <summary>
        /// Performs vertex drag
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Canvas_OnEllipseIsBeingDragged(object sender, MouseEventArgs e)
        {
            if (isDragging && sender is Shape draggableControl)
            {
                Point currentPosition = e.GetPosition(this);
                var transform = draggableControl.RenderTransform as TranslateTransform ?? new TranslateTransform();
                transform.X = originTT.X + (currentPosition.X - clickPosition.X);
                transform.Y = originTT.Y + (currentPosition.Y - clickPosition.Y);
                draggableControl.RenderTransform = new TranslateTransform(transform.X, transform.Y);
            }
        }

        /// <summary>
        /// Finishes vertex drag
        /// </summary>
        private void Canvas_OnEllipseLeftClickFinished(object sender, MouseButtonEventArgs e)
        {
            isDragging = false;
            var draggable = sender as Shape;
            draggable.ReleaseMouseCapture();
        }

        /// <summary>
        /// Toggles vertexcolor on right click
        /// </summary>
        private void Canvas_OnEllipseRightClick(object sender, MouseEventArgs e)
        {
            var shape = sender as Shape;
            shape.Fill = (shape.Fill == Brushes.DarkBlue) ? Brushes.DarkOrange : Brushes.DarkBlue;
        }

        private object FindVertexSpenningPoint(Point p)
        {
            return null;
        }

        /// <summary>
        /// Returns a new Ellipse shape object with OnClickListeners assigned
        /// </summary>
        private Ellipse CreateEllipse()
        {
            Ellipse ellipse = new Ellipse
            {
                Width = 50,
                Height = 50,
                Fill = Brushes.DarkBlue,
            };
            ellipse.MouseLeftButtonDown += Canvas_OnEllipseLeftClick;
            ellipse.MouseLeftButtonUp += Canvas_OnEllipseLeftClickFinished;
            ellipse.MouseRightButtonDown += Canvas_OnEllipseRightClick;
            ellipse.MouseMove += Canvas_OnEllipseIsBeingDragged;

            return ellipse;
        }

        private void PlaceNewVertexOnCanvas()
        {

        }

    }
}
