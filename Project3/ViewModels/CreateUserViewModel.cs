using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Project3.Messages;
using Project3.Models;

namespace Project3.ViewModels;

[INotifyPropertyChanged]
public partial class CreateUserViewModel : BaseViewModel
{
    public CreateUserViewModel()
    {
        User = new User();
    }
    [ObservableProperty]
    private User _user;
    
    [RelayCommand]
    private void Add()
    {
        WeakReferenceMessenger.Default.Send(new UserAddedMessage(User));
        WeakReferenceMessenger.Default.Send<ViewModelChangedMessage>(
            new ViewModelChangedMessage(App.ServiceProvider.GetService<UserListViewModel>()!));
    }
    
    [RelayCommand]
    private void Back()
    {
        WeakReferenceMessenger.Default.Send<ViewModelChangedMessage>(
            new ViewModelChangedMessage(App.ServiceProvider.GetService<UserListViewModel>()!));
    }
}