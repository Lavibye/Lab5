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

namespace Lab5
{
    public partial class MainWindow : Window
    {
        private readonly ISeriesCalculator seriesCalculator;
        public MainWindow()
        {
            InitializeComponent();
            seriesCalculator = new SeriesCalculator();
        }
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            ResultListBox.Items.Clear();

            double start = double.Parse(StartTextBox.Text);
            double end = double.Parse(EndTextBox.Text);
            double step = double.Parse(StepTextBox.Text);

            for (double x = start; x <= end; x += step)
            {
                int iterations = 5;

                double resultLoop = seriesCalculator.CalculateSeriesWithLoop(x, iterations);
                double resultRecursion = seriesCalculator.CalculateSeriesWithRecursion(x, iterations);

                ResultListBox.Items.Add($"x: {x}, y(цикл): {resultLoop:F3}, y(рекурсія): {resultRecursion:F3}");
            }
        }
    }
}
