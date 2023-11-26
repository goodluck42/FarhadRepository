using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Project3.Messages;

namespace Project3.ViewModels;

[INotifyPropertyChanged]
public partial class MainViewModel : BaseViewModel
{
    public MainViewModel()
    {
        WeakReferenceMessenger.Default.Register<ViewModelChangedMessage>(this, (sender, message) =>
        {
            CurrentViewModel = message.ViewModel;
        });


        var viewModel = App.ServiceProvider.GetService<UserListViewModel>()!;
        var message = new ViewModelChangedMessage(viewModel);
        
        WeakReferenceMessenger.Default.Send<ViewModelChangedMessage>(message);
    }
    [ObservableProperty]
    private BaseViewModel? _currentViewModel; // CurrentViewModel
}