﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Models
{
    public class MessageSendingData
    {
        public string Content { get; set; }

        public string RecipientEmail { get; set; }

        public int SenderId { get; set; }
       
    }
}
