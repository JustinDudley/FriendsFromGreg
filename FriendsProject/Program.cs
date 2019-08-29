using System;

namespace FriendsProject {
    class Program {
        static void Main(string[] args) {

            var f1 = new Friend("Jim", "513-555-1212", "fa@mail.com", true, 3);
            var f2 = new Friend("Alice", "513-555-1212", "fb@mail.com", true, 2);
            var f3 = new Friend("Bill", "513-555-1212", "fc@mail.com", false, 5);
            var f4 = new Friend("Kate", "513-555-1212", "fd@mail.com", false, 1);
            var f5 = new Friend("Pat", "513-555-1212", "fe@mail.com", false, 4);

            var friends = new Friend[] { f1, f2, f3, f4, f5 };

            foreach(var friend in friends) {
                Console.WriteLine(friend);
            }
        }
    }
}
