using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;

namespace SocialNetwork.PLL.Views
{
    public class AddFriendView
    {
        FriendService _friendService;
        public AddFriendView(FriendService friendService)
        {
           _friendService = friendService;
        }
        public void Show(User user)
        {
            try 
            {
                var friend = new Friend();
                Console.WriteLine("Введите почтовый адрес пользователя которого хотите добавить в друзья: ");
                friend.Friend_Email = Console.ReadLine();
                friend.UserId = user.Id;

                this._friendService.AddFriend(friend);
                SuccessMessage.Show("Вы успешно добавили пользователя в друзья!");
            }
            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователя с указанным почтовым адресом не существует!");
            }
            catch (Exception)
            {
                AlertMessage.Show("Произоша ошибка при добавлении пользотваеля в друзья!");
            }
        }
    }
}
