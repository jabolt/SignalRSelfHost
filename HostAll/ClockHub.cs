using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace HostAll
{
    public class ClockHub : Hub
    {

        Timer timer;

        public override Task OnConnected()
        {

            if (timer == null)
            {
                timer = new Timer(1000);

                timer.Elapsed += (s, e) =>
                {
                    {
                        Clients.All.showTime(DateTime.Now.ToString("hh:mm:ss"));
                    }
                };

                timer.Start();

            }
            return base.OnConnected();

        }
    }
}
