using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalR_Example_NET_Framework
{
    public class ChatHub : Hub
    {
        public void SendAll(string name, string message)
        {
            Clients.All.sendChat(name,message);
        }
    }
}