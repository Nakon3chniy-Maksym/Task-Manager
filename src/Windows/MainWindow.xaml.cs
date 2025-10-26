using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
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

namespace Task_Manager_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddTaskWindow addTaskWindow = new AddTaskWindow();
            addTaskWindow.Owner = this;
            addTaskWindow.ShowDialog();
        }


        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            //SettingsWindow settingsWindow = new SettingsWindow();
            //settingsWindow.Owner = this;
            //settingsWindow.ShowDialog();

            //var dialog = new OpenFileDialog
            //{
            //    Title = "Select a file",
            //    Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            //};

            //bool? result = dialog.ShowDialog();

            //if (result == true)
            //{
            //    string filepath = dialog.FileName;

            //    using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            //    {
            //        fs.Write(Encoding.UTF8.GetBytes("Hello, World!"), 0, "Hello, World!".Length);
            //    }

            //}
        }

    }
}
