using CommunityToolkit.Mvvm.ComponentModel;

namespace Project3.Models;

[INotifyPropertyChanged]
public partial class User
{
    [ObservableProperty]
    private string? _login;
    
    [ObservableProperty]
    private string? _password;
    
    [ObservableProperty]
    private int _id;
}