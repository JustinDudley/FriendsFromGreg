using System;
using System.Collections.Generic;
using System.Text;

namespace FriendsProject {
    class Friend {

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool BFF { get; set; } = false;
        public int HowLong { get; set; }
        

        public Friend(string name, string phone, string email, bool bff, int howlong) {
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
            this.BFF = bff;
            this.HowLong = howlong;
        }
        public Friend() {

        }
        public override string ToString() {
            return $"{Name} {Phone} {Email} {(BFF ? "BFF" : "")} {HowLong}";
        }
    }
}
