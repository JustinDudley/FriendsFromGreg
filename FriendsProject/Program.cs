using System;
using System.Collections.Generic;

namespace FriendsProject {
    class Program {
        static void Main(string[] args) {

            //List<int> integers = new List<int>();
            //integers.Add(17);
            //integers.Add(0);
            //integers.Add(88);
            //integers.Add(43);
            //var count = integers.Count;// how many items in collection
            //integers.Sort();
            //integers.Remove(0);

            var f1 = new Friend("Jim", "513-555-1212", "fa@mail.com", true, 3);
            var f2 = new Friend("Alice", "513-555-1212", "fb@mail.com", true, 2);
            var f3 = new Friend("Bill", "513-555-1212", "fc@mail.com", false, 5);
            var f4 = new Friend("Kate", "513-555-1212", "fd@mail.com", false, 1);
            var f5 = new Friend("Pat", "513-555-1212", "fe@mail.com", false, 4);

            //var friends = new Friend[] { f1, f2, f3, f4, f5 };
            var friends = new List<Friend>();
            friends.Add(f1);
            friends.Add(f2);
            friends.Add(f3);
            friends.Add(f4);
            friends.Add(f5);

            var aFriend = friends[0];

            foreach(var friend in friends) {
                friend.HowLong = (friend.BFF) ? 10 : 0;
                Console.WriteLine(friend);
            }

            var StateCodes = new Dictionary<string, string>();
            StateCodes.Add("OH", "Ohio");
            StateCodes.Add("KY", "Kentucky");
            StateCodes.Add("IN", "Indiana");
            var ohio = StateCodes["OH"];

            
        }
    }
}
