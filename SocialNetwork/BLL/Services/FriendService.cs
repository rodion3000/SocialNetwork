using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.DAL.Repositories;
using SocialNetwork.DAL.Entities;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Exceptions;

namespace SocialNetwork.BLL.Services
{
    public class FriendService
    {
        IFriendRepository friendRepository;
        IUserRepository userRepository;
        public FriendService()
        {
            friendRepository = new FriendRepository();
            userRepository = new UserRepository();
        }
        public void AddFriend(Friend friend)
        {
            var findFriend = userRepository.FindByEmail(friend.Friend_Email);
            if(findFriend == null) throw new UserNotFoundException();

            var friendEntity = new FriendEntity()
            {
                user_id = friend.UserId,
                friend_id = findFriend.id
            };

            if (friendRepository.Create(friendEntity) == 0)
                throw new Exception();
        }


    }
}
