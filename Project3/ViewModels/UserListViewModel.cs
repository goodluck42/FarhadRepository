﻿using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Project3.Messages;
using Project3.Models;

namespace Project3.ViewModels;

[INotifyPropertyChanged]
public partial class UserListViewModel : BaseViewModel
{
    public ObservableCollection<User> Users { get; set; } = null!;

    public UserListViewModel()
    {
        
    }

    [RelayCommand]
    private void AddUser()
    {
        var viewModel = App.ServiceProvider.GetService<CreateUserViewModel>()!;
        var message = new ViewModelChangedMessage(viewModel);

        WeakReferenceMessenger.Default.Send<ViewModelChangedMessage>(message);
    }
}