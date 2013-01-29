using System;
using NServiceBus;
using NServiceBus.Config;
using Amazon.InternalMessages.Sales;

namespace Amazon.ECommerce.Components.Sales
{
    public partial class SubmitOrderSender: ISubmitOrderSender, Amazon.ECommerce.Infrastructure.INServiceBusComponent
    {
        public void Send(SubmitOrder message)
		{
			Bus.Send(message);	
		}

        public IBus Bus { get; set; }
    }

    public interface ISubmitOrderSender
    {
        void Send(SubmitOrder message);
    }
}