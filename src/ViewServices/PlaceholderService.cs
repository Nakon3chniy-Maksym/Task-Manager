using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Task_Manager_GUITask_Manager_GUI.src.ViewServices
{
    public static class PlaceholderService
    {
        public static readonly DependencyProperty PlaceholderTextProperty =
            DependencyProperty.RegisterAttached("PlaceholderText", typeof(string), typeof(PlaceholderService), new PropertyMetadata(String.Empty));
        
        public static void SetPlaceholderText(UIElement element, string value) =>
            element.SetValue(PlaceholderTextProperty, value);

        public static string GetPlaceholderText(UIElement element) =>
            (string)element.GetValue(PlaceholderTextProperty);

        public static readonly DependencyProperty PlaceholderFontSizeProperty =
            DependencyProperty.RegisterAttached("PlaceholderFontSize", typeof(double), typeof(PlaceholderService), new PropertyMetadata(14.0));

        public static void SetPlaceholderFontSize(UIElement element, double value) =>
            element.SetValue(PlaceholderFontSizeProperty, value);

        public static double GetPlaceholderFontSize(UIElement element) =>
            (double)element.GetValue(PlaceholderFontSizeProperty);
        
    }
}
