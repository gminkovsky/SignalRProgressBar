using System;
using SignalR.Hubs;

namespace SignalrProgressDemo.Progress
{
    public class Chat : Hub
    {
        public void Send(String message)
        {
            Clients.addMessage(message);
        }
    }
}