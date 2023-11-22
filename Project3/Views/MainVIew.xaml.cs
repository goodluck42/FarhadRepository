using System.Windows;
using Project3.ViewModels;

namespace Project3.Views;

public partial class MainVIew : Window
{
    public MainVIew(MainViewModel mainViewModel)
    {
        InitializeComponent();

        DataContext = mainViewModel;
    }
}