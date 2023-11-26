using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Project3.Messages;

namespace Project3.ViewModels;

[INotifyPropertyChanged]
public partial class CreateUserViewModel : BaseViewModel
{
    [RelayCommand]
    private void Back()
    {
        WeakReferenceMessenger.Default.Send<ViewModelChangedMessage>(
            new ViewModelChangedMessage(App.ServiceProvider.GetService<UserListViewModel>()!));
    }
}