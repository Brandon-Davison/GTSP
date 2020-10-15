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

        }

        /// <summary>
        /// Starts vertex drag
        /// </summary>
        private void Canvas_OnEllipseLeftClick(object sender, MouseButtonEventArgs e)
        {
            
        }

        /// <summary>
        /// Performs vertex drag
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Canvas_OnEllipseIsBeingDragged(object sender, MouseEventArgs e)
        {

        }

        /// <summary>
        /// Finishes vertex drag
        /// </summary>
        private void Canvas_OnEllipseLeftClickFinished(object sender, MouseButtonEventArgs e)
        {

        }

        /// <summary>
        /// Colors vertex a new color on right click
        /// </summary>
        private void Canvas_OnEllipseRightClick(object sender, MouseEventArgs e)
        {

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

    }
}
