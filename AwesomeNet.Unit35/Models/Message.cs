using System;
using System.Collections.Generic;
using System.Linq;

namespace AwesomeNet.Unit35.Models
{
    public class Message
    {
    public int Id { get; set; }
    public string Text { get; set; }

    public string SenderId { get; set; }
    public User Sender { get; set; }

    public string ReciverId { get; set; }
    public User Reciver { get; set; }
    }

}
