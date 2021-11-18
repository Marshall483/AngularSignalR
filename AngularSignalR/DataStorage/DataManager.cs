using System;
using System.Collections.Generic;
using AngularSignalR.Models;

namespace AngularSignalR.DataStorage
{
    public static class DataManager
    {
        public static List<Message> GetMessages()
        {
            var r = new Random();

            return new List<Message>
            {
                new Message(r.Next(1, 400).ToString()),
                new Message(r.Next(1, 400).ToString()),
                new Message(r.Next(1, 400).ToString()),
                new Message(r.Next(1, 400).ToString()),
            };
        }
    }
}