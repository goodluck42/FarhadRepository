using Project3.ViewModels;

namespace Project3.Messages;

public class ViewModelChangedMessage
{
    public ViewModelChangedMessage(BaseViewModel viewModel)
    {
        ViewModel = viewModel;
    }
    
    public BaseViewModel ViewModel { get; }
}