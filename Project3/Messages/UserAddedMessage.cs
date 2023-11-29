using Project3.Models;

namespace Project3.Messages;

public class UserAddedMessage
{
    public UserAddedMessage(User user)
    {
        User = user;
    }
    
    public User User { get; }
}