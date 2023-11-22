using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;

namespace Project3.ViewModels;

[INotifyPropertyChanged]
public partial class MainViewModel : BaseViewModel
{
    public MainViewModel()
    {
        CurrentViewModel = new SingletonViewModel();
    }
    [ObservableProperty]
    private BaseViewModel _currentViewModel; // CurrentViewModel
}