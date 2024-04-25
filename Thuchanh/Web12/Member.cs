using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web12
{
    public class Member
    {
        public Member() { }
        public string Nickname;
        public string Color;
        public Member(string Nickname,string Color)
        {
            this.Nickname = Nickname;
            this.Color = Color;
        }
    }
}