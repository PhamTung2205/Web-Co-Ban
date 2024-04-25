using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web12
{
    public class Message
    {
        public Member Member;
        public string msg;
        public DateTime date;
        public Message(Member Nick, string msg ,DateTime date)
        {
            this.Member = Nick;
            this.msg = msg;
            this.date = date;
        }
        
    }
}