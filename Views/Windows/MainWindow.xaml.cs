
using System.Windows;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;
using OxyPlot.Wpf;
using System;
using System.Xaml.Schema;
using course.ViewModels;
using System.Windows.Data;
using course.Models;
using course.ViewModels.Base;

namespace course
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var model = new PlotModel();
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom });
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Left });

            var series = new LineSeries()
            {
                Color = OxyColors.Red,
                StrokeThickness = 2,
                ItemsSource = ((MainWindowViewModel)DataContext).TestDataPoints,

                DataFieldX = "XValue",
                DataFieldY = "YValue"

            };

            model.Series.Add(series);

            ((PlotView)FindName("plotView")).Model = model;




        }

        private void ContextMenu_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
