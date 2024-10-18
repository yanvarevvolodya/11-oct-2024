﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1_second_task
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ColorComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (ColorComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                string colorName = selectedItem.Tag.ToString();
                Color color = (Color)ColorConverter.ConvertFromString(colorName);
                DrawingCanvas.DefaultDrawingAttributes.Color = color;
            }
        }

        private void BrushSizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double brushSize = BrushSizeSlider.Value;

            DrawingCanvas.DefaultDrawingAttributes.Width = brushSize;
            DrawingCanvas.DefaultDrawingAttributes.Height = brushSize;
        }
    }
}