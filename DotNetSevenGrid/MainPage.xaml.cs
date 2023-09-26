using Microsoft.Maui.Controls.Shapes;
using Path = Microsoft.Maui.Controls.Shapes.Path;

namespace DotNetSevenGrid
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            AddPath();
        }

        void AddPath()
        {
            grid.VerticalOptions = LayoutOptions.Center;
            grid.HorizontalOptions = LayoutOptions.Center;
            Path squareFillandStrokePath = GetPath("M 10,100 L 100,100 100,50Z");
            squareFillandStrokePath.Fill = new SolidColorBrush(Colors.Yellow);
            squareFillandStrokePath.Stroke = new SolidColorBrush(Colors.Black);
            grid.Children.Add(squareFillandStrokePath);
        }

        Path GetPath(string pathData)
        {
            Path path = new Path();
            var data = new PathGeometryConverter().ConvertFromString(pathData);
            path.Data = data as Geometry;
            return path;
        }


    }
}