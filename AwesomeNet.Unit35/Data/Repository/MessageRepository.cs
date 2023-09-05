using AwesomeNet.Unit35.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AwesomeNet.Unit35.Data.Repository
{
    public class MessageRepository : Repository<Message>
    {
        public MessageRepository(ApplicationDbContext db) : base(db)
        {

        }
        public void AddMessage(User fromUser, User toUser, string message)
        {
            if ((fromUser == null) && (toUser == null))
            {
                var item = new Message()
                {
                    MessageTimeMark = System.DateTime.Now,
                    SenderId = fromUser.Id,
                    Sender = fromUser,
                    Reciver = toUser,
                    ReciverId = toUser.Id,
                    Text = message
                };

                Create(item);
            }
        }
        public List<Message> GetMessageByUsers(User fromUser, User toUser)
        {
            Set.Include(x => x.Sender);
            Set.Include(x => x.Reciver);

            var fromMsg = Set.AsEnumerable().
                Where(x => x.SenderId == fromUser.Id && x.ReciverId == toUser.Id).
                ToList();
            var toMsg = Set.AsEnumerable().
                Where(x => x.SenderId == toUser.Id && x.ReciverId == fromUser.Id)
                .ToList();

            var msgList = new List<Message>();
            msgList.AddRange(fromMsg);
            msgList.AddRange(toMsg);
            msgList.OrderBy(x => x.Id);

            return msgList;
            
        }
    }
}
