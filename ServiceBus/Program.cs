using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Messaging;


namespace ServiceBus
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Endpoint=sb://servicebusdarek.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=BLR/qaryuwFRTnUVpADRhJADNjMX+Tk4Eh+XMVzMGgo=";
            var queueName = "queuedark";

            var client = QueueClient.CreateFromConnectionString(connectionString, queueName);
            //int i = 0;

            //while (i < 1000)
            //{
            //    var message = new BrokeredMessage("This is a test message! Darek mm");

            //    Console.WriteLine(String.Format("Message id: {0}", message.MessageId));

            //    client.Send(message);
            //    i++;
            //}

            //Console.WriteLine("Message successfully sent! Press ENTER to exit program");
            //Console.ReadLine();

            client.OnMessage(message2 =>
            {
                Console.WriteLine(String.Format("Message body: {0}", message2.GetBody<String>()));
                Console.WriteLine(String.Format("Message id: {0}", message2.MessageId));
            });

            Console.WriteLine("Press ENTER to exit program");
            Console.ReadLine();
        }
    }
}
