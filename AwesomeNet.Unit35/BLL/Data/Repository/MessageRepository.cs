using AwesomeNet.BLL.Data;
using AwesomeNet.BLL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AwesomeNet.BLL.Data.Repository
{
    public class MessageRepository : Repository<Message>
    {
        public MessageRepository(ApplicationDbContext db) : base(db)
        {
        }

        public List<Message> GetMessages(User sender, User recipient)
        {
            Set.Include(x => x.Recipient);
            Set.Include(x => x.Sender);

            var from = Set.AsEnumerable().Where(x => x.SenderId == sender.Id && x.RecipientId == recipient.Id).ToList();
            var to = Set.AsEnumerable().Where(x => x.SenderId == recipient.Id && x.RecipientId == sender.Id).ToList();

            var itog = new List<Message>();
            itog.AddRange(from);
            itog.AddRange(to);
            itog.OrderBy(x => x.Id);
            return itog;
        }
        //public void AddMessage(User fromUser, User toUser, string message)
        //{
        //    if ((fromUser == null) && (toUser == null))
        //    {
        //        var item = new Message()
        //        {
        //            MessageTimeMark = System.DateTime.Now,
        //            SenderId = fromUser.Id,
        //            Sender = fromUser,
        //            Reciver = toUser,
        //            ReciverId = toUser.Id,
        //            Text = message
        //        };

        //        Create(item);
        //    }
        //}
        //public List<Message> GetMessageByUsers(User fromUser, User toUser)
        //{

        //}
    }
}
