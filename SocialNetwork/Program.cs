using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Views;

namespace SocialNetwork;

class Program
{
    private static FriendService _friendService;
    private static MessageService _messageService;
    private static UserService _userService;
    public static MainView MainView;
    public static RegistrationView RegistrationView;
    public static AuthentificationView AuthentificationView;
    public static UserMenuView UserMenuView;
    public static UserInfoView UserInfoView;
    public static UserDataUpdateView UserDataUpdateView;
    public static MessageSendingView MessageSendingView;
    public static UserIncomingMessageView UserIncomingMessageView;
    public static UserOutcomingMessageView UserOutcomingMessageView;
    public static AddFriendView AddFriendView;
    
    static void Main(string[] args)
    {
        _userService = new UserService();
        _messageService = new MessageService();
        _friendService = new FriendService();

        MainView = new MainView();
        RegistrationView = new RegistrationView(_userService);
        AuthentificationView = new AuthentificationView(_userService);
        UserMenuView = new UserMenuView(_userService);
        UserInfoView = new UserInfoView();
        UserDataUpdateView = new UserDataUpdateView(_userService);
        MessageSendingView = new MessageSendingView(_messageService, _userService);
        UserIncomingMessageView = new UserIncomingMessageView();
        UserOutcomingMessageView = new UserOutcomingMessageView();
        AddFriendView = new AddFriendView(_friendService);
        

        while (true)
        {
            MainView.Show();
        }
    }
}