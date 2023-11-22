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

namespace Project1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            // var stackPanel = new StackPanel();
            // var textBlock = new TextBlock();
            // var checkBox = new CheckBox()
            // {
            //     Content = "CheckBox"
            // };
            //
            // textBlock.Text = "Click me!";
            //
            // MyButton.Content = stackPanel;
            //
            // stackPanel.Children.Add(textBlock);
            // stackPanel.Children.Add(checkBox);
            //
            // MyButton.Content = stackPanel;

            
            Semen.Text = "Hello WPF";
        }
    }
}