using System;
using System.Threading;
using SignalR.Hubs;

namespace SignalrProgressDemo.Common
{
    public class BookingHub : Hub
    {
        public void Send(String message)
        {

            // Call the addMessage method on all clients.
            Clients.displayMessage(message);
        }

        public void BookFlight(String from, String to)
        {
            // Book first leg
            Clients.displayMessage(String.Format("Booking flight: {0}-{1} ...", from, to));
            Thread.Sleep(2000);

            // Book return 
            Clients.displayMessage(String.Format("Booking flight: {0}-{1} ...", to, from));
            Thread.Sleep(3000);

            // Book return 
            Clients.displayMessage(String.Format("Booking flight: {0}-{1} ...", to, from));
            Thread.Sleep(2000);

            // Some return value
            Clients.displayMessage("Flight booked successfully.");
        }

        public void ProcessPendingEmails()
        {
            Clients.updateGaugeBar(10);
            Thread.Sleep(2000);

            Clients.updateGaugeBar(40);
            Thread.Sleep(3000);

            Clients.updateGaugeBar(64);
            Thread.Sleep(2000);

            Clients.updateGaugeBar(77);
            Thread.Sleep(2000);

            Clients.updateGaugeBar(92);
            Thread.Sleep(3000);

            Clients.updateGaugeBar(99);
           Thread.Sleep(2000);

           Clients.updateGaugeBar(100);       
        }
    }
}